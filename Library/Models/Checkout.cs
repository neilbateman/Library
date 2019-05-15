namespace Library.Models
{
  public class Checkout
  {
    private int _id;
    private int book_id;
    private int author_id;
    private int _copyNumber;
    private int _patron_id;
    private bool _overdue;

    public int Id { get => _id; }
    public int Book_id { get => book_id; }
    public int Author_id { get => author_id; }
    public int CopyNumber { get => _copyNumber; }
    public int Patron_id { get => _patron_id; }
    public bool Overdue { get => _overdue; }
  }
}
