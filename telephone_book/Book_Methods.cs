
public class Book_Methods
{
    Book books = new Book();
    User book = new User();
    public void UserAdd()
    {
        Console.Write("Lütfen isim giriniz             : ");
        string? newname = Console.ReadLine().ToLower();
   
        Console.Write("Lütfen soyisim giriniz          : ");
        string? newlastName = Console.ReadLine().ToLower();
   
        Console.Write("Lütfen telefon numarası giriniz : ");
        string? newphoneNumber = Console.ReadLine();

        books.UserList.Add(new User(newname, newlastName, newphoneNumber));
        Console.WriteLine(newname + " " +  newlastName + " rehbere kaydedilmiştir..");
    }

    public void UserDelete()
    {   
    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
    string? deletedUser = Console.ReadLine().ToLower();
    
        foreach (var item in books.UserList)
        {
            if (item.Name.ToLower() == deletedUser || item.LastName.ToLower() == deletedUser)
            book = item;
        }
        
        if (book.Name == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n * Silmeyi sonlandırmak için : (1)\n * Yeniden denemek için      : (2)");
            string? delortryagain = Console.ReadLine();
            if (delortryagain == "1")
            {
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
            }
            else
            {
                UserDelete();
            }
        } 
        else
        {
                Console.WriteLine($"{book.Name} {book.LastName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string? yesnochoise = Console.ReadLine().ToLower();

                if (yesnochoise == "y")
                {
                books.UserList.Remove(book);
                Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
                }
                else if (yesnochoise == "n")
                {
                Console.WriteLine("Silme işlemi iptal edildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yapıldı. Ana menüye yönlendiriliyorsunuz.");
                    Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                    StartMenu();
                }
        }
    }


    public void UserUpdate()
    {   
        Console.WriteLine("Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string? updatedUser = Console.ReadLine().ToLower();
        foreach (var item in books.UserList)
        {
            if (updatedUser == item.Name || updatedUser == item.LastName)
            {
                book=item;
            }
        }
        if (book.Name == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n * Guncellemeyi sonlandırmak için : (1)\n * Yeniden denemek için      : (2)");
            string? updateortryagain = Console.ReadLine();
            if (updateortryagain == "1")
            {
                Console.WriteLine("Guncelleme işlemi başarıyla gerçekleştirildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
            }
            else
            {
                UserUpdate();
            }
        }
        else
        {
            Console.WriteLine("Guncellecek tel no giriniz: ");
                string? newphonenumber = Console.ReadLine();
                Console.WriteLine($"{book.Name} {book.LastName} isimli kişi bilgileri guncellenmek üzere, onaylıyor musunuz ?(y/n)");
            string? yesnochoise = Console.ReadLine().ToLower();

            if (yesnochoise == "y")
            {
                book.PhoneNumber = newphonenumber;
                Console.WriteLine("Guncelleme işlemi başarıyla gerçekleştirildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
            }
            else
            {
                Console.WriteLine("Guncelleme işlemi iptal edildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
            }
        }
    }

    public void UserList()
    {
        Console.WriteLine("Telefon Rehberi\n **********************************************");
        foreach (var item in books.UserList)
        {
            Console.WriteLine($"isim: {item.Name}\nSoyisim: {item.LastName}\nTelefon Numarası: {item.PhoneNumber}\n-");
        }
        Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
        StartMenu();
    }

    public void UserSearch()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n **********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\n Telefon numarasına göre arama yapmak için: (2)");
        string? searchselect = Console.ReadLine();
            if (searchselect == "1")
            {
                SearchNameOrLastName();
            }
            else if (searchselect == "1")
            {
                SearchPhonenumber();
            }
    }

    public void SearchPhonenumber()
    {
        Console.Write("Aramak istediginiz telefon numarasini giriniz: ");
        string? searchphonenumber = Console.ReadLine().ToLower();

        foreach (var item in books.UserList)
        {
            if (searchphonenumber == item.PhoneNumber)
            {
                book=item;
            }
        }

        if (book.PhoneNumber is null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n * Aramayi sonlandırmak için : (1)\n * Yeniden denemek için      : (2)");
            string? updateortryagain = Console.ReadLine();
            if (updateortryagain == "1")
            {
                Console.WriteLine("Arama sonlandirildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
            }
            else
            {
                UserSearch();
            }
        }
        else
        {
            Console.WriteLine("Arama Sonuçlarınız:\n **********************************************");
            Console.WriteLine($"isim: {book.Name}\nSoyisim: {book.LastName}\nTelefon Numarası: {book.PhoneNumber}\n-");
        }
    }

    public void SearchNameOrLastName()
    {
        Console.Write("Aramak istediginiz isim veya soyisim giriniz: ");
        string? searchnameorlastname = Console.ReadLine().ToLower();

        foreach (var item in books.UserList)
        {
            if (searchnameorlastname == item.Name || searchnameorlastname == item.LastName)
            {
                book=item;
            }
        }

        if (book.Name == null)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n * Aramayi sonlandirmak için : (1)\n * Yeniden denemek için      : (2)");
            string? updateortryagain = Console.ReadLine();
            if (updateortryagain == "1")
            {
                Console.WriteLine("Arama sonlandirildi.");
                Console.WriteLine("Ana menüye dönmek için: (1)\nProgrami bitirmek icin: (2)");
                StartMenu();
            }
            else
            {
                UserSearch();
            }
        }
        else
        {
            Console.WriteLine("Arama Sonuçlarınız:\n **********************************************");
            Console.WriteLine($"isim: {book.Name}\nSoyisim: {book.LastName}\nTelefon Numarası: {book.PhoneNumber}\n-");
        }
    }

    public void StartMenu()
    {
        string decision = Console.ReadLine();
        if (decision == "1")
        {
            Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        else if (decision == "2")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Hatalı tuşlama yaptınız tekrar deneyin.");
            StartMenu();
        }
    }
}

