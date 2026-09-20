using Microsoft.VisualBasic;
using System.Drawing;

namespace basics04
{
    enum Genre { Fiction, NonFiction, Science }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            Book myBook = new Book();
            // This will cause a compilation error because 'password' is private and cannot be accessed from outside the Book class.
            // Console.WriteLine(myBook.password); 
            #endregion


            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            Console.WriteLine(myBook.copiesInStock);
            #endregion


            #region Add a public string Title; field to Book. Set it and print it from Main.
            myBook.Title = "C# Programming";
            Console.WriteLine(myBook.Title);
            #endregion


            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
            myBook.genre = Genre.Science;
            Console.WriteLine(myBook.genre);
            #endregion


            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion


            #region Given int genreNumber = 1;, cast it into a Genre value and print the result.
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            #endregion


            #region Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it. 
           
            string genreString = genre.ToString();
            Console.WriteLine(genreString);
            #endregion


            #region Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result.
            string genreText = "Science";
            Genre genreParsed = (Genre)Enum.Parse(typeof(Genre), genreText);

            Console.WriteLine(genreParsed);
            #endregion


            #region Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion.Print "Unknown genre" if it fails.


             genreText = "Mystery";
            if (Enum.TryParse<Genre>(genreText, out Genre result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Unknown genre"); // Output: Unknown genre
            }

            #endregion




        }
    }
}
