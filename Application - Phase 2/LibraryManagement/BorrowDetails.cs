using System;
namespace LibraryManagement;
public enum Status{Default , Borrowed , Returned }
public class BorrowDetails
{
    static int s_borrowId = 100;
    public string BorrowId { get; set; }
    public string BookID { get; set; }
    public string UserId { get; set; }
    public DateTime BorrowDate { get; set; }
    public Status BorrowStatus { get; set; }

    public BorrowDetails(string bookId , string userId , DateTime borrowDate , Status borrowStatus )
    {
        s_borrowId++;
        BorrowId = "LB" + s_borrowId ;
        BookID = bookId ;
        UserId = userId ;
        BorrowDate = borrowDate ;
        BorrowStatus = borrowStatus ;
    }

}
