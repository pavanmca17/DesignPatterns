namespace DesignPatterns.Builder.Models
{
    public class PersonDTO
    {
        public PersonDTO()
        {
            Address = new AddressDTO();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public AddressDTO Address { get; set; }


    }
}
