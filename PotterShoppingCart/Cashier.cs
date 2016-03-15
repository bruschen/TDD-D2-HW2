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
            int amount=0;

            amount = (BookList.Select(m => m.Quantity).Sum())*100;

            return amount;
        }
    }
}
