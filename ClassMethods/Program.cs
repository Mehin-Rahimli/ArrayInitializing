namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookLibrary booklibrary = new BookLibrary(" ");
            Book book = new Book("Yalniz ozumuzunkuler", "Cingiz Abdullayev");
            Book book2 = new Book("Little women", "Louisa May Alcott");
            Book book3 = new Book("Harry Potter and Half-Blood Prince", "J.K.Rowling");
            Book book4 = new Book("Etiraflar Vadisi","Cingiz Abdullayev");
            booklibrary.AddBook(book);
            booklibrary.AddBook(book2);
            booklibrary.AddBook(book3);
            booklibrary.AddBook(book4);
            booklibrary.BorrowBook(book);
            booklibrary.ReturnBook(book);
            booklibrary.SearchByAuthor(book);
            booklibrary.ShowAll();




        }
    }
}
