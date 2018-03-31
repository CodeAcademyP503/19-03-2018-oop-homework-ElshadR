using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
       

        static void Main(string[] args)
        {


            //List<int> ededler = new List<int>() { 65, 59, 58 };
            //var temp = 1;
            //for (int i = 0; i < ededler.Count; i++)
            //{

            //    for (int j = i; j < ededler.Count - 1; j++)
            //    {

            //        if (ededler[i] < ededler[j + 1])
            //        {
            //            temp = ededler[i];
            //            ededler[i] = ededler[j + 1];
            //            ededler[j + 1] = temp;

            //        }

            //    }
            //    Console.WriteLine(ededler[i]);
            //}





            Book.Basliq();



        }
    }
    class Book
    {
        public static int _id;
        public Book(string _name, string _author, int _isbn, DateTime _data, int _price)
        {
            Name = _name;
            Author = _author;
            ISBN = _isbn;
            PublishData = _data;
            Price = _price;
            ID = _id;
            _id++;


        }
        public  string Name;
        public string Author;
        public int ISBN;
        public DateTime PublishData;
        public int Price;
        public int ID;
        public static List<Book> books = new List<Book>();
        public static void Basliq()
        {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------");
            
            
        Console.WriteLine("1. Kitab elave et.");
        Console.WriteLine("2. Kitablari goster.");
        Console.WriteLine("3. Kitab sil.");
        Console.WriteLine("4. Kitab melumatlarini deyisdir.");
        Console.WriteLine("5. Kitablari tarix siralamasina gore goster.");
        Console.WriteLine("6. Kitablari qiymet siralamasina gore goster.");
        Console.WriteLine("------------------------------------------------");
        Console.Write("Hansi emri yerine yetirmek isteyirsiniz");
        var emr = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (emr)
        {
            case 1:
                Create();
                break;
            case 2:
                Read();
                break;
            case 3:
                    Delete();
                break;
            case 4:
                    Update();
                break;
            case 5:
                    DataTimeAzalma();
                break;
            case 6:
                    QiymetAzalmasi();
                break;
            default:
                break;
                    
        }

    }
        public static List<string> name = new List<string>();
        public static List<string> author = new List<string>();
        public static List<int> isbn1 = new List<int>();
        public static List<DateTime> data1 = new List<DateTime>();
        public static List<int> price1= new List<int>();
        public static void Create()
        {
            Console.WriteLine("------------------------------------------------");
            Console.Write("Kitabin adini daxil et: ");
            var Name = Console.ReadLine();
            name.Add(Name);
            Console.Write("Kitabin muellifini daxil et: ");
            var Author = Console.ReadLine();
            author.Add(Author);
            Console.Write("Kitabin ISBN-sini daxil et: ");
            var isbn = Convert.ToInt32(Console.ReadLine());
            isbn1.Add(isbn);
            Console.Write("Kitabin datasini daxil et: ");
            var data = Convert.ToDateTime(Console.ReadLine());
            data1.Add(data);
            Console.Write("Kitabin qiymetini daxil edin: ");
            var price = Convert.ToInt32(Console.ReadLine());
            price1.Add(price);
            Book kitab = new Book(Name,Author,isbn,data,price);
            books.Add(kitab);
            Read();

        }
        public static void Read()
        {
            var b = 1;
            foreach (var book in books)
            {
                Console.WriteLine((b) + "" + ".- NAME-" + book.Name + ". AUTHOR-" + book.Author + ". ISBN-" + book.ISBN + ". DATA-" + book.PublishData + ". PRICE-" + book.Price);
                b++;
            }
            Basliq();
        }
        public static void Delete()
        {
            Console.Write("Hansi kitabi silmek isteyirsiniz: ");
            var delete =Convert.ToInt32(Console.ReadLine());
            books.Remove(books[delete - 1]);
            Read();
        }
        public static void Update()
        {
            Console.WriteLine("1. Melumatlarin hamisini deyismek.");
            Console.WriteLine("2. Adini deyismek.");
            Console.WriteLine("3. Muellifini deyismek.");
            Console.WriteLine("4. ISBN-sini deyismek.");
            Console.WriteLine("5. Datasini deyismek.");
            Console.WriteLine("6. Qiymetini deyismek.");
            Console.WriteLine("7. Evvelki sehifeye qayitmaq.");
            Console.WriteLine("------------------------------------------------");
            Console.Write(" Deyismek isteiyiniz emri secin: ");
            var emr = Convert.ToInt32(Console.ReadLine());
            switch (emr)
            {

                case 1:
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Hansi kitabi deyismek isteyirsiniz: ");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kitabin adini daxil et: ");
                    var Name = Console.ReadLine();
                    name[num1 - 1] = Name;
                    Console.Write("Kitabin muellifini daxil et: ");
                    var Author = Console.ReadLine();
                    author[num1 - 1] = Author;
                    Console.Write("Kitabin ISBN-sini daxil et: ");
                    var isbn = Convert.ToInt32(Console.ReadLine());
                    isbn1[num1 - 1] = isbn;
                    Console.Write("Kitabin datasini daxil et: ");
                    var data = Convert.ToDateTime(Console.ReadLine());
                    data1[num1 - 1] = data;
                    Console.Write("Kitabin qiymetini daxil edin: ");
                    var price = Convert.ToInt32(Console.ReadLine());
                    price1[num1 - 1] = price;
                    books[num1 - 1] = new Book(Name, Author, isbn, data, price);
                    Read();
                    break;
                case 2:
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Hansi kitabin adini deyismek isteyirsiniz: ");
                    var num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kitabin adini daxil et: ");
                    var Name2 = Console.ReadLine();
                    name[num2 - 1] = Name2;
                    string Author2 = author[num2 - 1];
                    int isbn2 = isbn1[num2 - 1];
                    DateTime data2 = data1[num2 - 1];
                    int price2 = price1[num2 - 1];
                    books[num2 - 1] = new Book(Name2, Author2, isbn2, data2, price2);
                    Read();

                    break;
                case 3:
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Hansi kitabin muellifini deyismek isteyirsiniz: ");
                    var num3 = Convert.ToInt32(Console.ReadLine());
                    string Name3 = name[num3 - 1];
                    Console.Write(" Kitabin muellifini deyismek: ");
                    var Author3 = Console.ReadLine();
                   author[num3 - 1] = Author3;
                    int isbn3 = isbn1[num3 - 1];
                    DateTime data3 = data1[num3 - 1];
                    int price3 = price1[num3 - 1];
                    books[num3 - 1] = new Book(Name3, Author3, isbn3, data3, price3);
                    Read();
                    break;
                case 4:
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Hansi kitabin ISBN-sini deyismek isteyirsiniz: ");
                    var num4 = Convert.ToInt32(Console.ReadLine());
                    string Name4 = name[num4 - 1];
                    string Author4 = author[num4 - 1];
                    Console.Write("Kitabin ISBN-sini daxil et: ");
                    var isbn4 = Convert.ToInt32(Console.ReadLine());
                    isbn1[num4 - 1] = isbn4;
                    DateTime data4 = data1[num4 - 1];
                    int price4 = price1[num4 - 1];
                    books[num4 - 1] = new Book(Name4, Author4, isbn4, data4, price4);
                    Read();
                    break;
                case 5:
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Hansi kitabin qiymetini deyismek isteyirsiniz: ");
                    var num5 = Convert.ToInt32(Console.ReadLine());
                    string Name5 = name[num5 - 1];
                    string Author5 = author[num5 - 1];
                    int isbn5 = isbn1[num5 - 1];
                    Console.Write("Kitabin datasini daxil et: ");
                    var data5 = Convert.ToDateTime(Console.ReadLine());
                    data1[num5 - 1] = data5;
                    Console.Write("Kitabin qiymetini daxil edin: ");
                    int price5 = price1[num5 - 1];
                    books[num5 - 1] = new Book(Name5, Author5, isbn5, data5, price5);
                    Read();
                    break;
                case 6:
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Hansi kitabin qiymetini deyismek isteyirsiniz: ");
                    var num6 = Convert.ToInt32(Console.ReadLine());
                    string Name6 = name[num6 - 1];
                    string Author6 = author[num6 - 1];
                    int isbn6 = isbn1[num6 - 1];
                    DateTime data6 = data1[num6 - 1];
                    Console.Write("Kitabin qiymetini daxil edin: ");
                    var price6 = Convert.ToInt32(Console.ReadLine());
                    price1[num6 - 1] = price6;
                    books[num6 - 1] = new Book(Name6, Author6, isbn6, data6, price6);
                    Read();
                    break;
                case 7:
                    Basliq();
                    break;
                default:
                    Console.WriteLine("------------------------------------------------");
                    Read();
                    break;
                    Read();

            }
        }
        public static void QiymetAzalmasi()
        {
             List<int> price = new List<int>();

            if (price.Count > 0)
            {
                for (int i = 0; i < price.Count; i++)
                {
                    price.Remove(price[i]);
                    //price.Remove(price[i + 1]);
                }
            }
            for (int i = 0; i < price.Count; i++)
            {
                Console.WriteLine(price[i]);
            }


            foreach (var book in books)
            {
                price.Add(book.Price);
            }
            Console.WriteLine(price.Count);
          
            var b = 1;
            for (int i = 0; i < price.Count; i++)
            {
                for (int j = i; j < price.Count - 1; j++)
                {
                    if (price[j] < price[j + 1])
                    {
                        int temp = price[i];
                        price[i] = price[j + 1];
                        price[j + 1] = temp;

                    }
                }
                
               

                foreach (var book in books)
                {
                    if (book.Price == price[i])
                    {

                        Console.WriteLine((b) + "" + ".- NAME-" + book.Name + ". AUTHOR-" + book.Author + ". ISBN-" + book.ISBN + ". DATA-" + book.PublishData + ". PRICE-" + book.Price);


                        b++;


                    }

                }               


            }
           

            Basliq();


        }
         
        public static void DataTimeAzalma()
        {
            List<Book> data = new List<Book>();
           
        }

    }

}
