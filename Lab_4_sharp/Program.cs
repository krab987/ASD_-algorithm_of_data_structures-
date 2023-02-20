
using Lab_4_sharp;

internal class Program
{
    private static void Main(string[] args)
    {
        string bookName = "Book", where, what;
        bool checkWhere;

        Item book = new Item(bookName);

        int choose;
        while (true)
        {
            Console.WriteLine("Add - 0, Del - 1, 2 - exit");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    book.Add("Book", "Chapter1");
                    book.Add("Book", "Chapter2");
                    book.Add("Book", "Chapter3");
                    book.Add("Chapter1", "Paragraph1");
                    book.Add("Chapter1", "Paragraph2");
                    book.Add("Chapter1", "Paragraph3");
                    book.Add("Paragraph1", "Sentence 1");
                    book.Add("Paragraph1", "Sentence 2");
                    book.Add("Paragraph1", "Sentence 3");
                    book.Add("Sentence 1", "word11");
                    book.Add("Sentence 1", "word12");
                    book.Add("Sentence 1", "word13");
                    book.Add("Sentence 1", "word14");

                    book.Add("Sentence 2", "word21");
                    book.Add("Sentence 2", "word22");
                    book.Add("Sentence 2", "word23");
                    book.Add("Sentence 2", "word24");

                    Console.WriteLine("\n " + book.GetInfo());
                    break;
                case 1:
                    book.Delete("Chapter1", "Paragraph2");
                    book.Delete("Sentence 1", "word11");
                    Console.WriteLine("\n " + book.GetInfo());
                    break;
                case 2:
                    break;
            }
        }
    }
}