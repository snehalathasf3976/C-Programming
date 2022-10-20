using System;
using System.Collections.Generic;
namespace LibraryManagement;
public class Operations
{
    static List<UserDetails> userList = new List<UserDetails>();
    static List<BookDetails> bookList = new List<BookDetails>();
    static List<BorrowDetails> borrowList = new List<BorrowDetails>();
    public static void MainMenu()
    {
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Select the Option to Perform \n1.User Registration \n2.User Login \n3.Exit");
            int choice = int.Parse (Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    condition = "no";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("NO such Option Select Within 1-3");
                    break;
                }
            }
                
        } while (condition == "YES");

    }
    static void Registration()
    {
        System.Console.WriteLine("\n\n  Registration    \n\n");
        System.Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter Your Gender (Male/Female/TransGender)");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Your Department (EEE/ECE/CSE)");
        Department department = Enum.Parse<Department>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Your Mobile Number");
        long mobileNumber = int.Parse (Console.ReadLine());

        System.Console.WriteLine("Enter your Mail Id: ");
        string mailId = Console.ReadLine();
        
        UserDetails user = new UserDetails(name , gender , department , mobileNumber , mailId);
        userList.Add(user);
        System.Console.WriteLine("Registration Successfull!!! \n Your User Id is: "+user.UserId);
    }

    static void Login()
    {
        System.Console.WriteLine("\n\n  Login   \n\n");
        System.Console.WriteLine("Enter Your User Id");
        string userId = Console.ReadLine().ToUpper();
        int count=0;
        foreach(UserDetails user in userList)
        {
            if(user.UserId == userId)
            {
                System.Console.WriteLine("Valid User");
                count = 1;
                Submenu(user);
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("Invalid User");
        }
        
    }
    static void Submenu(UserDetails user)
    {
        System.Console.WriteLine("\n\nSub Menu\n\n");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter Your Operation to do \n1.Borrow Book \n2.Show Borrow History \n3.Return Book \n4.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    BorrowBook(user);
                    break;
                }
                case 2:
                {
                    BorrowedHistory(user);
                    break;
                }
                case 3:
                {
                    ReturnBook(user);
                    break;
                }
                case 4:
                {
                    condition = "no";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("No Such Option Select Within 1-4");
                    break;
                }
            }
        }while(condition == "YES");
    }
    static void ReturnBook(UserDetails user)
    {
        BorrowedHistory(user);
        System.Console.WriteLine("Enter the Book ID to Return");
        string borrowId = Console.ReadLine().ToUpper();
        foreach(BorrowDetails borrow in borrowList)
        {
            if(borrow.BorrowId == borrowId)
            {
                DateTime date = borrow.BorrowDate.AddDays(15);
                TimeSpan fineDays = DateTime.Now - date ;
                if(fineDays.Days >= 15)
                {
                    System.Console.WriteLine("You have the Fine Amount of: "+fineDays.Days);
                    System.Console.WriteLine("Are You Gonna Pay the Fine (yes/NO)");
                    string condition = Console.ReadLine().ToUpper();
                    if(condition == "YES")
                    {
                        System.Console.WriteLine("Pay the Fine Amount: "+fineDays.Days);
                        int fineday = int.Parse(Console.ReadLine());
                        if(fineDays.Days == fineday)
                        {
                            borrow.BorrowStatus = Status.Returned;
                        }
                        else
                        {
                            System.Console.WriteLine("You didn't Pay the Full Amount");
                        }
                    }
                }

            }
        }
    }
    static void BorrowBook(UserDetails user)
    {
        DisplayBooks();
        int count = 0 ;
        System.Console.WriteLine("Enter the Book Id to Borrow");
        string bookId = Console.ReadLine().ToUpper();
        foreach(BookDetails book in bookList)
        {
            if(book.BookId == bookId)
            {
                if(book.BookCount>0)
                {
                    System.Console.WriteLine("Book Available");
                    foreach(BorrowDetails borrow in borrowList)
                    {
                        if(borrow.UserId == user.UserId)
                        {
                            if(borrow.BorrowStatus == Status.Borrowed)
                            {
                                count++;
                            }
                        }
                    }
                    if(count >= 3 )
                    {
                        System.Console.WriteLine("You Have Already Borrowed MAximum Book.\nReturn Them First to Borrow Another ");
                    }
                    else
                    {
                        System.Console.WriteLine("Book Allocated to you SuccessFully");
                        BorrowDetails borrow = new BorrowDetails(bookId , user.UserId , DateTime.Now , Status.Borrowed);
                        System.Console.WriteLine("Your Borrowed Id is: "+borrow.BorrowId);
                        borrowList.Add(borrow);
                        book.BookCount--;
        }
                }
                else
                {
                    System.Console.WriteLine("Book Not Available");
                    foreach (BorrowDetails borrow in borrowList)
                    {
                        if(bookId == borrow.BookID)
                        {
                            DateTime date = borrow.BorrowDate.AddDays(15);
                            System.Console.WriteLine("Book Will be Available in: "+date);
                        }
                    }
                }
            }
        }
    }
    static void BorrowedHistory(UserDetails user)
    {
        System.Console.WriteLine("|Borrow Id | Book Id | User Id | Borrow Date | Status |");
        foreach(BorrowDetails borrow in borrowList)
        {
            if(borrow.UserId == user.UserId)
            {
                System.Console.WriteLine($"| {borrow.BorrowId ,-7} | {borrow.BookID , -7} | {borrow.UserId , -7} | {borrow.BorrowDate.ToString("dd/MM/yyyy"),-12} | {borrow.BorrowStatus , -7}  ");
            }
        }

    }

    static void DisplayBooks()
    {
        System.Console.WriteLine("|Book Id | Book Name | Author Name | No.Of.Books |");
        System.Console.WriteLine("--------------------------------------------------");
        foreach(BookDetails book in bookList)
        {
            System.Console.WriteLine($"|{book.BookId , -7} | {book.BookName , -9} | {book.AuthorName , -11} | {book.BookCount, -11} |");
        }
    }
    public static void DefaultDetails()
    {
        userList.Add(new UserDetails("Ravichandren" , Gender.Male , Department.EEE , 644892849764, "ravi@gmail.com"));
        userList.Add(new UserDetails("PriyaDharshini" , Gender.Female , Department.CSE , 9876543210, "priya@gmail.com"));


        bookList.Add(new BookDetails("C#" , "Author1" , 3));
        bookList.Add(new BookDetails("HTML" , "Author2" , 5));
        bookList.Add(new BookDetails("CSS" , "Author1" , 3));
        bookList.Add(new BookDetails("JS" , "Author1" , 3));
        bookList.Add(new BookDetails("TS" , "Author2" , 2));


        borrowList.Add(new BorrowDetails("BID101" , "SF3001" ,new DateTime(2022,04,10) , Status.Borrowed));
        borrowList.Add(new BorrowDetails("BID103" , "SF3001" ,new DateTime(2022,04,12) , Status.Borrowed));
        borrowList.Add(new BorrowDetails("BID104" , "SF3001" ,new DateTime(2022,04,15) , Status.Returned));
        borrowList.Add(new BorrowDetails("BID102" , "SF3002" ,new DateTime(2022,04,11) , Status.Borrowed));
        borrowList.Add(new BorrowDetails("BID105" , "SF3002" ,new DateTime(2022,04,15) , Status.Returned));
    }
}