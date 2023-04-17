public class Book
{
    private List<User> userList = new List<User>();

    public List<User> UserList { get => userList; set => userList = value; }

    public Book()
    {
        UserList.Add(new User("ahmet", "kara", "5325001112"));
        UserList.Add(new User("mehmet", "beyaz", "5325001113"));
        UserList.Add(new User("ayse", "sari", "5325001114"));
        UserList.Add(new User("fatma", "mor", "5325001115"));
        UserList.Add(new User("deniz", "mavi", "5325001116"));
    }
}

