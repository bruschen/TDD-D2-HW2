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
            int bookPrice = 100;

            if (bookCnt>1)
            {
                bookPrice =(int)(100 * 0.95);
            }

            return bookCnt*bookPrice;
        }
    }
}
