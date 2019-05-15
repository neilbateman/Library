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
      // Author.ClearAll();
      // Book.ClearAll();
    }
    public AuthorTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=library_tests;";
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
    // [TestMethod]
    // public void Find_ReturnsAuthorInDatabase_Author()
    // {
    //
    // }
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
