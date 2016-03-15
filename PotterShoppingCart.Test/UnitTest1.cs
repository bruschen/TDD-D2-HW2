using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 第一集_一本_總金額_100()
        {
            //arrange
            List<BookOrder> BookList = new List<BookOrder>(){
                new BookOrder() { BookName="HP1", Quantity=1 }
            };
            Cashier cashier= new Cashier();
            int expect= 100;

            //act
            int actual=cashier.check(BookList);

            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void 第一集_一本_第二本_一本_總金額_190()
        {
            //arrange
            List<BookOrder> BookList = new List<BookOrder>(){
                new BookOrder() { BookName="HP1", Quantity=1 },
                new BookOrder() { BookName="HP2", Quantity=1 }
            };
            Cashier cashier = new Cashier();
            int expect = 190;

            //act
            int actual = cashier.check(BookList);

            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void 第一集_一本_第二本_一本_第三本_一本_總金額_270()
        {
            //arrange
            List<BookOrder> BookList = new List<BookOrder>(){
                new BookOrder() { BookName="HP1", Quantity=1 },
                new BookOrder() { BookName="HP2", Quantity=1 },
                new BookOrder() { BookName="HP3", Quantity=1 },
            };
            Cashier cashier = new Cashier();
            int expect = 270;

            //act
            int actual = cashier.check(BookList);

            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void 第一集_一本_第二本_一本_第三本_一本_第四本_一本_總金額_320()
        {
            //arrange
            List<BookOrder> BookList = new List<BookOrder>(){
                new BookOrder() { BookName="HP1", Quantity=1 },
                new BookOrder() { BookName="HP2", Quantity=1 },
                new BookOrder() { BookName="HP3", Quantity=1 },
                new BookOrder() { BookName="HP4", Quantity=1 }
            };
            Cashier cashier = new Cashier();
            int expect = 320;

            //act
            int actual = cashier.check(BookList);

            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}
