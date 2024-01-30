﻿using BEL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using BAL;

namespace TestTailor
{
    [TestClass]
    public class UnitTestInsertCustomer
    {
        [TestMethod]
        public void TestInserCustomer()
        {
            // Arrange
            // Create a mock database connection
            String s = "Data Source=Usman_Shabbir;Initial Catalog=TailorManagmentSystem;Integrated Security=True";
            // Create an instance of the class containing the GetAllRecord method
            Operations or = new Operations(s);

            // Create a sample customer
            Customer sampleCustomer = new Customer
            {
                name = "test99",
                phoneNumber = "1234567890",
                email = "text99@example.com"
            };

            // Create a sample SqlCommand (you might need to adjust this based on your actual implementation)
            SqlCommand expectedCommand = new SqlCommand("InsertCustomer")
            {
                CommandType = CommandType.StoredProcedure
            };
            expectedCommand.Parameters.Add("@cust_name", SqlDbType.VarChar, 255).Value = sampleCustomer.name;
            expectedCommand.Parameters.Add("@phone_number", SqlDbType.VarChar, 20).Value = sampleCustomer.phoneNumber;
            expectedCommand.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = sampleCustomer.email;

            // Act
            int result =or.inserCustomer(sampleCustomer);

            // Assert the result
            Assert.AreEqual(1, result); // Assuming 1 for successful execution
        }
    }
}