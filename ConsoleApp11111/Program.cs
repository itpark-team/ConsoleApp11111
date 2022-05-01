using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        struct Product
        {
            public int amount; //сколько товаров
            public string name;
            public int Id;
        }

        static void Main(string[] args)
        {
            int maxProducts = 10;
            int indexCurrentProduct = -1;
            Product[] products = new Product[maxProducts];
            Product inputProduct = new Product();

            Console.WriteLine("кто ты");
            Console.WriteLine("если покупатель нажми 1 если сотрудник пороль");

            int chooseRole = Convert.ToInt32(Console.ReadLine());

            if (chooseRole == 1)
            {
                Console.WriteLine("хорошо товары ");
            }
            else if (chooseRole == 111)
            {
                Console.WriteLine("что нужно 1 добавить товар 2 проверить ");
                int chooseAction = Convert.ToInt32(Console.ReadLine());

                if (chooseAction == 1)
                {
                    Console.WriteLine("айди товара");
                    inputProduct.Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("имя товара");
                    inputProduct.name = Console.ReadLine();

                    Console.WriteLine("количество товара");
                    inputProduct.amount = Convert.ToInt32(Console.ReadLine());

                    indexCurrentProduct++;

                    products[indexCurrentProduct] = inputProduct;

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"{products[i].Id} ---  {products[i].name} --- {products[i].amount}");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}