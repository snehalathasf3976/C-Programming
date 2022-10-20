namespace LibraryManagement;
public class BookDetails
{
    static int s_bookId = 100 ;
    public string BookId { get; set; }
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int BookCount { get; set; }


    public BookDetails(string bookName , string authorName , int bookCount)
    {
        s_bookId++;
        BookId = "BID" + s_bookId;
        BookName = bookName;
        AuthorName = authorName ;
        BookCount = bookCount ; 
    }
}