using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary_Access
    {
    public class Order
        {
        private static int LastId = 0;

        static Order()
            {
            LastId = 0;
            }

        public Order()
            {
            this.Id = LastId += 7;
            }

        public int Id { get; private set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }

        public void SetCustomer(Customer customer)
            {
           

            }
        }
    }
