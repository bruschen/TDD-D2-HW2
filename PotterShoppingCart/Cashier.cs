using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Cashier
    {
        public int check(List<BookOrder> BookList)
        {
            int bookCnt=BookList.Select(m => m.Quantity).Sum();
            int bookPrice = 0;

            bookPrice = GetDiscount(bookCnt);

            return bookCnt*bookPrice;
        }

        private static int GetDiscount(int bookCnt)
        {
            if (bookCnt > 3)
            {
                return (int)(100 * 0.8);
            }
            else if (bookCnt > 2)
            {
                return (int)(100 * 0.9);
            }
            else if (bookCnt > 1)
            {
                return (int)(100 * 0.95);
            }
            else
            {
                return 100;
            }
        }
    }
}
