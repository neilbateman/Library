namespace Library.Models
{
  public class Author
  {
    private int _id;
    private string _firstName;
    private string _lastName;

    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }
    public int id { get => _id; }

    public Author (string firstName, string lastName, int id = 0)
    {
      _id = id;
      _firstName = firstName;
      _lastName = lastName;
    }

  }
}
