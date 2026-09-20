namespace basics04
{
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
        }
    }
}
