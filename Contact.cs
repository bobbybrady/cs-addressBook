namespace addressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}