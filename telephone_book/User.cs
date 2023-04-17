public class User
{
    private string name;
    private string lastName;
    private string phoneNumber;

    public string Name {get => name; set => name = value;}
    public string LastName {get => lastName; set => lastName = value;}
    public string PhoneNumber {get => phoneNumber; set => phoneNumber = value;}

    public User(string Name, string LastName, string PhoneNumber)
    {
        name = Name;
        lastName = LastName;
        phoneNumber = PhoneNumber;
    }

    public User(){}
}