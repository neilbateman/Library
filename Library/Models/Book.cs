using System.Collections.Generic;
using MySql.Data.MySqlClient;

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

    public override bool Equals(System.Object otherBook)
    {
      if (!(otherBook is Book))
      {
        return false;
      }
      else
      {
        Book newBook = (Book) otherBook;
        bool idEquality = this.Id == newBook.Id;
        bool titleEquality = this.Title == newBook.Title;
        bool copyNumberEquality = this.CopyNumber == newBook.CopyNumber;
        return (idEquality && titleEquality && copyNumberEquality);
      }
    }
    public static Book Find(int id)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM books WHERE id = (@searchId);";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@searchId";
      searchId.Value = id;
      cmd.Parameters.Add(searchId);
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      int bookId = 0;
      string title = "";
      int copyNumber = 0;
      while(rdr.Read())
      {
        bookId = rdr.GetInt32(0);
        title = rdr.GetString(1);
        copyNumber = rdr.GetInt32(2);
      }
      Book newBook = new Book(title, copyNumber, bookId);
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return newBook;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO books (title, copy_number) VALUES (@title, @copy_number);";
      MySqlParameter title = new MySqlParameter();
      title.ParameterName = "@title";
      title.Value = this.Title;
      cmd.Parameters.Add(title);
      MySqlParameter copy_number = new MySqlParameter();
      copy_number.ParameterName = "@copy_number";
      copy_number.Value = this.CopyNumber;
      cmd.Parameters.Add(copy_number);
      cmd.ExecuteNonQuery();
      _id = (int) cmd.LastInsertedId; // <-- This line is new!
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static List<Book> GetAll()
    {
      List<Book> allBooks = new List<Book> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM books;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int bookId = rdr.GetInt32(0);
        string bookTitle = rdr.GetString(1);
        int bookNumber = rdr.GetInt32(2);
        Book newBook = new Book(bookTitle, bookNumber, bookId);
        allBooks.Add(newBook);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allBooks;
    }

    public void Edit(string newTitle)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"UPDATE books SET title = @newTitle WHERE id = @searchId;";
      MySqlParameter searchId = new MySqlParameter();
      searchId.ParameterName = "@searchId";
      searchId.Value = _id;
      cmd.Parameters.Add(searchId);
      MySqlParameter title = new MySqlParameter();
      title.ParameterName = "@newTitle";
      title.Value = newTitle;
      cmd.Parameters.Add(title);
      cmd.ExecuteNonQuery();
      _title = newTitle; // <--- This line is new!
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = @"DELETE FROM books;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
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
