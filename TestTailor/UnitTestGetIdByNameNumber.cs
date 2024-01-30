using BEL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using BAL;

namespace TestTailor
{
    [TestClass]
    public class UnitTestGetIdByNameNumber
    {
        [TestMethod]
        public void TestGetIdByNamePhoneNo()
        {
            // Arrange
            // Create a mock database connection
            String s = "Data Source=Usman_Shabbir;Initial Catalog=TailorManagmentSystem;Integrated Security=True";

            // Create an instance of the class containing the GetAllRecord method
            Operations or = new Operations(s);

            // Create a sample customer
            Customer sampleCustomer = new Customer
            {
                name = "test44",
                phoneNumber = "test44"
            };

            // Create a sample DataTable for the expected result
            DataTable expectedDataTable = new DataTable();
            // Add columns if needed
            expectedDataTable.Columns.Add("customer_id", typeof(int));
            expectedDataTable.Columns.Add("cust_name", typeof(string));
            expectedDataTable.Columns.Add("phone_number", typeof(string));
            expectedDataTable.Columns.Add("email", typeof(string));
            DataRow row = expectedDataTable.NewRow();
            row["customer_id"] = 3013;
            row["cust_name"] = "test44";
            row["phone_number"] = "test44";
            row["email"] = "test44";
            expectedDataTable.Rows.Add(row);

            // Act
            DataTable result = or.GetIdByNamePhoneNo(sampleCustomer);
            //Assert.IsTrue(DataTableComaparer.AreEqual(expectedDataTable, result));

            // Assert the result
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Rows.Count, 1);
        }
    }
}
