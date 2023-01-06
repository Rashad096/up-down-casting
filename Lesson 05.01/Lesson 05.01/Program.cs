using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Lesson_05._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product notebook1 = new Notebook() { Name = "Asus",Price=2600, RAM = 16, Storage = 256 };
            Product notebook2 = new Notebook() { Name = "MacBook", Price=3999,RAM = 16, Storage = 200 };
            Product notebook3 = new Notebook() { Name = "MacAir", Price=3459,RAM = 16, Storage = 250 };
            Product notebook4 = new Notebook() { Name = "IMac", Price=5990,RAM = 16, Storage = 400 };
            Product phone1 = new Phone() { Name = "IPhone13",Price=2679,SimCount=1};
            Product phone2 = new Phone() { Name = "SamsungS20", Price=3500,SimCount=2};
            Product phone3 = new Phone() { Name = "Huawei:)", Price=1500,SimCount=2};
            Product phone4 = new Phone() { Name = "SamsungG5", Price=6500,SimCount=2};



            Product[] products = { notebook1, notebook2,notebook3,notebook4, phone1, phone2,phone3,phone4 };

            string opt;
            do
            {
                Console.WriteLine("\n=================== Menu =====================\n");

                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax bax");
                Console.WriteLine("5. Telefonlarin sayina bax bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n=================== Products =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }

                        break;
                    case "2":
                        Console.WriteLine("\n=================== Notebooks =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {

                                var nt = products[i] as Notebook;
                                Console.WriteLine(nt.Name + " - " + nt.Price + " " + nt.RAM);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n=================== Phones =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }

                        break;
                    case "4":
                        int notebookCount = 0;
                        Console.WriteLine("\n=================== Notebook count =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                                notebookCount++;
                        }

                        Console.WriteLine("Notebook sayi: " + notebookCount);
                        break;
                    case "5":
                        int phoneCount = 0;
                        Console.WriteLine("\n=================== Phone count =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                phoneCount++;
                        }

                        Console.WriteLine("Phone sayi: " + phoneCount);
                        break;
                    case "6":
                        Console.WriteLine("\n=================== Notebooklarin  ortalama qiymeti =====================\n");
                        int sum = 0;
                        int noteCount = 0;
                        int result;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                sum += (int)products[i].Price;
                                noteCount++;
                            }
                        }
                        result = sum / noteCount;
                        Console.WriteLine("Noutlarin ortalama qiymeti:" +result);
                        break;
                    case "7":
                        Console.WriteLine("\n=================== Phonlarin  ortalama qiymeti =====================\n");
                        int phonesum = 0;
                        int phoneCounter = 0;
                        int result1;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                            {
                                phonesum += (int)products[i].Price;
                                phoneCounter++;
                            }
                        }
                        result1 = phonesum / phoneCounter;
                        Console.WriteLine("Noutlarin ortalama qiymeti:" + result1);
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi!");
                        break;
                    default:
                        Console.Beep();
                        Console.WriteLine("Duzgun secim edin!");
                        break;
                }

            } while (opt != "0");

        }

       
    }
}
