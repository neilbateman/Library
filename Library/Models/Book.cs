namespace Library.Models
{
  public class Book
  {
    private int _id;
    private string _title;
    private int _copyNumber;


    public int Id { get => _id; }
    public string Title { get => _title; set => _title = value; }
    public int CopyNumber { get => _copyNumber; set => _copyNumber = value; }

    public Book(string title, int copyNumber, int id = 0)
    {
      Title = title;
      CopyNumber = copyNumber;
    }

    // public static Update()
    // {
    //
    // }
    //
    // public static Delete()
    // {
    //
    // }
    //
    // public static List<Book> GetAll()
    // {
    //   List<Book> allBooks
    // }
  }
}
