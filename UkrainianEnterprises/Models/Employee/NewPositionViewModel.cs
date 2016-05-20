using System.ComponentModel.DataAnnotations;
using UkrainianEnterprises.Common;

namespace UkrainianEnterprises.Models.Employee
{
    public class NewPositionViewModel
    {
        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [Required]
        public PositionLevel Level { get; set; }
    }
}