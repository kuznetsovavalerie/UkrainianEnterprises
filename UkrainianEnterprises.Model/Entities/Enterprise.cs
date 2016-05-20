using System.Collections.Generic;

namespace UkrainianEnterprises.Common.Entities
{
    /// <summary>
    /// The enterprise entity
    /// </summary>
    public class Enterprise
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public EnterpriseCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>
        /// The website.
        /// </value>
        public string Website { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public ICollection<Location> Locations { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Enterprise"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        public bool Approved { get; set; }
    }
}
