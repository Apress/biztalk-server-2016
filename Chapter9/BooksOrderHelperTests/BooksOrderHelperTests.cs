using Microsoft.VisualStudio.TestTools.UnitTesting;
using BooksOrderHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BooksOrderHelper.Tests
{
    [TestClass()]
    public class BooksOrderHelperTests
    {
        [TestMethod()]
        public void returnTotalAmountTest()
        {
            #region Arrange  
                int price = 1000;
                int units = 9;
                int expectedValue = 9000;
                int iReturn = 0;
            BooksOrderHelper objBooksOrderHelper = new BooksOrderHelper();
            #endregion Arrange
            #region act
                iReturn = objBooksOrderHelper.returnTotalAmount(price, units);
            #endregion act
            #region Assert            
                Assert.AreEqual(expectedValue, iReturn);
            #endregion Assert

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void returnTotalAmountTestHighAmount()
        {
            #region Arrange  
            int price = 1000;
            int units = 20;
            int iReturn = 0;
            BooksOrderHelper objBooksOrderHelper = new BooksOrderHelper();
            #endregion Arrange
            #region act
            iReturn = objBooksOrderHelper.returnTotalAmount(price, units);
            #endregion act
            #region Assert            
            //assertion is managed by the ExpectedException attribute.
            #endregion Assert

        }
    }
}