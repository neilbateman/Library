using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Models;
using System.Collections.Generic;
using System;

namespace Library.Tests
{
  [TestClass]
  public class AuthorTest: IDisposable
  {
    public void Dispose()
    {
      Author.ClearAll();
      Book.ClearAll();
    }
    public AuthorTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=library_tests;";
    }

    [TestMethod]
    public void GetAll_ReturnsAllAuthorObjects_AuthorList()
    {
      //Arrange
      string firstName1 = "Semor";
      string lastName1 = "Butts";
      string firstName2 = "Mike";
      string lastName2 = "Hawk";
      Author newAuthor1 = new Author(firstName1, lastName1);
      newAuthor1.Save();
      Author newAuthor2 = new Author(firstName2, lastName2);
      newAuthor2.Save();
      List<Author> newAuthor = new List<Author> { newAuthor1, newAuthor2 };

      //Act
      List<Author> result = Author.GetAll();

      //Assert
      CollectionAssert.AreEqual(newAuthor, result);
    }

    [TestMethod]
    public void Find_ReturnsAuthorInDatabase_Author()
    {
      //Arrange
      Author testAuthor = new Author("John", "Wayne");
      testAuthor.Save();

      //Act
      Author foundAuthor = Author.Find(testAuthor.Id);

      //Assert
      Assert.AreEqual(testAuthor, foundAuthor);
    }
    // [TestMethod]
    // public void Equals_ReturnsTrueIfNamesAreTheSame_Author()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void GetAll_ReturnsAllAuthorObjects_AuthorList()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void AuthorConstructor_CreatesInstanceOfAuthor_Author()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void GetName_ReturnsName_String()
    // {
    //
    // }
    // [TestMethod]
    // public void Save_SavesAuthorToDatabase_AuthorList()
    // {
    //
    // }
    // [TestMethod]
    // public void Save_DatabaseAssignsIdToAuthor_Id()
    // {
    //
    // }
    //
    //
    // [TestMethod]
    // public void DeleteAuthor_DeletesAuthorAssociationsFromDatabase_AuthorList()
    // {
    //
    // }
    // [TestMethod]
    // public void Test_AddBook_AddsBookToAuthor()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void GetBooks_RetrievesAllBooksWithAuthor_BookList()
    // {
    //
    // }
  }
}
