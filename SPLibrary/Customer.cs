namespace SPLibrary
{
    public class Customer
    {
        public string Id { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;

        public override string ToString()
        {
            return$"{Id} {Nickname} {LastName} {Name} {PhoneNumber} {Adress}";
        }
    }
}
