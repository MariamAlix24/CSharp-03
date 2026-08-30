namespace G_ASP_NET_99_C_Basics_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Question 1

            /* int pages = 464;
             bool isAvailable = true;
             if (pages > 300 && isAvailable == true)
             Console.WriteLine("You can borrow this book");*/
            #endregion

            #region Question 2
            /* string title = "Refactoring";
             switch (title)
             {
                 case "Clean Code":
                     Console.WriteLine("Great choice!");
                     break;
                 case "Refactoring":
                     Console.WriteLine("Nice pick!");
                     break;
                 default:
                     Console.WriteLine("Never heard of it.");
                     break;
             }*/

            #endregion
            #region Question3
            /* int pages = 464;
             string sizeLabel = pages > 300 ? "Long Book" : "Small Book";
             Console.WriteLine(sizeLabel);*/
            #endregion

            #region Question 4
            string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            for (int i = 0; i < books.Length; i++) {
                Console.WriteLine($"Book {i + 1}: {books[i]}");

            }
            #endregion
            #region Question5

            int index = 0;
            while (index < books.Length) {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion

            #region Question6


            int count= 0;
            do
            {
                Console.WriteLine("checking book..");
                count++;
                
            }

            while (count < 3 );
            #endregion
            #region Question 7
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion
        }
    }
}
