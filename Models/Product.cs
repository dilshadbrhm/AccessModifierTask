using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersEncapsulationTask.Models
{
    internal class Product
    {
        private string _brandName;
        private string _model;
        private decimal _price;
        private decimal _cost;
        private decimal _income;
        private int _count;

        public string Brand
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _brandName = value;
                }
                else
                {
                    Console.WriteLine("Adi duzgun daxil edin");
                }
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length >= 2)
                {
                    _brandName = value;
                }
                else
                {
                    Console.WriteLine("Model adini duzgun daxil edin");
                }
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Mehsulun sayi 0 dan boyuk olmalidi");
                }

            }
        }
        public decimal Income
        {
            get
            {
               
                return _income;
            }
            set
            {
                value = 0;
                _income = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Qiymet menfi ola bilmez");
                }

            }
        }
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value >= 0)
                {
                    _cost = value;
                }
                else
                {
                    Console.WriteLine("Xercleri duzgun daxil edin");
                }

            }
        }

        public Product(string brand, string model, decimal price, decimal cost, int count)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand:{Brand} Model:{Model} price:{Price} Cost:{Cost} Income:{Income} Count:{Count}");
        }

        public void Sale(int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("Satis miqdari 0-dan boyuk olmalidir.");
                return;
            }

            if (Count >= count && count > 0)
            {
                Count -= count;

                Income += (Price - Cost) * count;
                Console.WriteLine("Satis ugurla heyata kecirildi");
            }

            else
            {
                Console.WriteLine("Tessufler olsun mehsul movcud deyil");
            }
        }


        public void Refill(int count)
        {
            if (count > 0)
            {
                Count += count;
            }
        }
    }
}

