
internal class Program
{
    private static void Main(string[] args)
    {
        Book_Methods book_Methods = new Book_Methods();
        
        while (true)
        {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
        Console.WriteLine("******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 1:
            book_Methods.UserAdd();
            continue;
            case 2:
            book_Methods.UserDelete();
            continue;
            case 3:
            book_Methods.UserUpdate();
            continue;
            case 4:
            book_Methods.UserList();
            continue;
            case 5:
            book_Methods.UserSearch();
            continue;
        }

        book_Methods.StartMenu();
        }
        
    }
}
