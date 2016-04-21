namespace UkrainianEnterprises.Model
{
    public class Employee
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public Position Position { get; set; }

        public Enterprise Enterprise { get; set; }

        public Location Location { get; set; }

        public Department Department { get; set; }

        public Office Office { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Photo { get; set; }

        public string Education { get; set; }
    }
}