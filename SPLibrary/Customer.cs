namespace SPLibrary
{
    public class Customer : IContainer
    {
        public string Id { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;

        public override string ToString() => $"{Id};{Nickname};{LastName};{Name};{PhoneNumber};{Adress}";

        public bool IsEmpty { get => Id == string.Empty && Nickname == string.Empty && LastName == string.Empty && Name == string.Empty && PhoneNumber == string.Empty && Adress == string.Empty; }
    }
}
