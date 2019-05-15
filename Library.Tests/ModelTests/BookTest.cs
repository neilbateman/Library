using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Models;
using System.Collections.Generic;
using System;

namespace Library.Tests
{
  [TestClass]
  public class BookTest : IDisposable
  {

    public void Dispose()
    {
      Book.ClearAll();
    }

    public BookTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=library_tests;";
    }

    [TestMethod]
    public void BookConstructor_CreatesInstanceOfBook_Book()
    {
      Book newBook = new Book("test", 1);
      Assert.AreEqual(typeof(Book), newBook.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      Book newBook = new Book("test", 1);
      Assert.AreEqual("test", newBook.Title);
    }

    [TestMethod]
    public void GetCount_ReturnsBookCopyNumber_1()
    {
      Book newBook = new Book("test", 3);
      Assert.AreEqual(3, newBook.CopyNumber);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      Book newBook = new Book("test", 1);
      newBook.Title = "test2";
      Assert.AreEqual("test2", newBook.Title);
    }


  }

  // [TestMethod]
  // public void GetAll_ReturnsEmptyList_BookList()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void GetAll_ReturnsBooks_BookList()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void Find_ReturnsCorrectBookFromDatabase_Book()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void Equals_ReturnsTrueIfTitlesAreTheSame_Book()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void Save_SavesToDatabase_BookList()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void Save_AssignsIdToObject_Id()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void Edit_UpdatesBookInDatabase_String()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void DeleteBook_DeletesBookAssociationsFromDatabase_BookList()
  // {
  //
  // }
  //
  // [TestMethod]
  // public void GetAuthors_ReturnsAllBookAuthors_AuthorList()
  // {
  //
  // }
  // [TestMethod]
  // public void AddAuthor_AddsAuthorToBook_AuthorList()
  // {
  //
  // }

}
