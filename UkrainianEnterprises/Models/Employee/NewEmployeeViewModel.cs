using System.ComponentModel.DataAnnotations;

namespace UkrainianEnterprises.Models.Employee
{
    public class NewEmployeeViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Patronymic { get; set; }

        [Required]
        public int PositionID { get; set; }

        [Required]
        public int EnterpriseID { get; set; }

        [Required]
        public int LocationID { get; set; }

        public int OfficeID { get; set; }

        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Education { get; set; }
    }
}