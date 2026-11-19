using System.Linq.Expressions;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            /*Console.WriteLine("enter id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name :");
            string name = Console.ReadLine();*/
            #endregion

            #region TOString
             Book mybook = new ();
             mybook.title = "GOT";
             mybook.pages = 200;
             Console.WriteLine(mybook.ToString());
            #endregion
            #region EQ()
             Book mybook1 = new Book() { title = "days", pages = 180 };
             Book mybook2= new Book() { title = "days", pages = 180 };
             Console.WriteLine(mybook1.Equals(mybook2));
            #endregion
            #region GHC()
             Book mybook11 = new Book() { title = "days", pages = 180 };
             Book mybook22 = new Book() { title = "days", pages = 180 };
             Console.WriteLine(mybook11.GetHashCode());
             Console.WriteLine(mybook22.GetHashCode());
            #endregion
            #region Get()
            Book mybook3 = new Book() { title = "escape", pages = 300 };
            Console.WriteLine(mybook3.GetType());
            #endregion
            #region try()
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
            #region
            int pagess = 300;
            double a = pagess;
            double price = 49.99;
            int xx = (int)price;
            Console.WriteLine(xx);
            string pagesText = "464";
            int Npages = Convert.ToInt32(pagesText);
            Console.WriteLine(Npages);
            string yearText = "2023";
            int years = int.Parse(yearText);
            Console.WriteLine(years);
            string badText = "abc";
            bool reslut = int.TryParse(badText, out int bad);
            Console.WriteLine(reslut);
            Console.WriteLine(bad);
            if (reslut == false)
            {
                Console.WriteLine("Invalid number");
            }
            int npages = 464;
            string nnn = npages.ToString();
            Console.WriteLine(nnn.GetType());
            int copies = 100;
            object boxedCopies = copies;
            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);
            #endregion
        }
    }
}
