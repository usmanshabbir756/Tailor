using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.SymbolStore;
using BAL;
using System.Data;
using System.Diagnostics;

namespace TestTailor
{
    [TestClass]
    public class UnitTestRecord
    {
        [TestMethod]
        public void TestGetAllRecord()
        {
            // Arrange
            // Create a mock database connection
            String s = "Data Source=Usman_Shabbir;Initial Catalog=TailorManagmentSystem;Integrated Security=True";

            // Create an instance of the class containing the GetAllRecord method
            Operations or = new Operations(s);

            // Act
            DataTable result = or.GetAllRecord();
           // Assert
            // Perform assertions based on expectations
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Rows.Count);
        }
    }
}
