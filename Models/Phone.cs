using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersEncapsulationTask.Models
{
    internal class Phone : Product
    {
        private int _ram;
        private string _color;
        private decimal _balance;

        public int Ram
        {
            get
            {
                return _ram;
            }
            set
            {
                if (value > 0 && value % 2 == 0)
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin");
                }

            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value.Length == 0)
                {
                    value = "black";
                    _color = value;
                }
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                value = 0;
                _balance = value;
            }


        }

        public Phone(int ram, string color, decimal balance, string brand, string model, decimal price, decimal cost, int count) : base(brand, model, price, cost, count)
        {
            Ram = ram;
            Color = color;
            Balance = balance;

        }
       
       
      
        public void Call(int seconds)
        {
            if (seconds <= 0)
            {
                Console.WriteLine("Zeng vaxti 0 dan boyuk olmalidir.");
                return;
            }

            decimal price = seconds * 0.1m;
            if (price <= _balance)
            {
                Console.WriteLine("Zeng edildi");
            }
            else
            {
                Console.WriteLine("Kifayet qeder vesait qalmayib");
            }
        }
        public void Pay(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Pul miqdari 0 dan boyuk olmalidir.");
                return;
            }
            _balance += money;
            Console.WriteLine($"Balansiniz:{_balance}");
        }
    }
}
