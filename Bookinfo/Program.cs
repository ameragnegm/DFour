namespace Bookinfo
{
    internal class Program
    {
        struct book
        {
            public string title;
            public string author;
            public int publication_Year;
            public Genre genre;

        }
        enum Genre
        {
            Fiction,
            NonFiction,
            Mystery,
            ScienceFiction,
            Biography
        }


        static void Main(string[] args)
        {

            book[] BOOK = new book[3];


            for (int i = 0; i < BOOK.Length; i++)
            {
                Console.WriteLine($"Enter Book Number {i + 1} Data: \nTitle:");
                BOOK[i].title = Console.ReadLine();

                Console.WriteLine("Author:");
                BOOK[i].author = Console.ReadLine();

                Console.WriteLine("Publication Year:");
                BOOK[i].publication_Year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genre:");
                string inputGen = Console.ReadLine();
                if (Enum.TryParse(inputGen, true, out Genre genre) && Enum.IsDefined(typeof(Genre), genre))
                {
                    BOOK[i].genre = genre;
                }
                else
                {
                    Console.WriteLine("Invalid genre entered.");
                    return;
                }
            }

            for (int i = 0; i < BOOK.Length; i++)
            {

                Console.WriteLine($"\nBook Number {i + 1} Details : \n Title: {BOOK[i].title} \n Author : {BOOK[i].author} \n Publication Year : {BOOK[i].publication_Year} \n Genre : {BOOK[i].genre} \n\n ");

            }

        }


    }

}
