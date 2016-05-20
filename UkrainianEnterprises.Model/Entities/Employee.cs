namespace UkrainianEnterprises.Common.Entities
{
    /// <summary>
    /// Enterprise employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the patronymic.
        /// </summary>
        /// <value>
        /// The patronymic.
        /// </value>
        public string Patronymic { get; set; }

        /// <summary>
        /// Gets or sets the job position.
        /// </summary>
        /// <value>
        /// The job position.
        /// </value>
        public Position Position { get; set; }

        /// <summary>
        /// Gets or sets the enterprise.
        /// </summary>
        /// <value>
        /// The enterprise.
        /// </value>
        public Enterprise Enterprise { get; set; }

        /// <summary>
        /// Gets or sets the job location.
        /// </summary>
        /// <value>
        /// The job location.
        /// </value>
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public Department Department { get; set; }

        /// <summary>
        /// Gets or sets the office.
        /// </summary>
        /// <value>
        /// The office.
        /// </value>
        public Office Office { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the photo.
        /// </summary>
        /// <value>
        /// The photo.
        /// </value>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// Gets or sets the education.
        /// </summary>
        /// <value>
        /// The education.
        /// </value>
        public string Education { get; set; }

        /// <summary>
        /// Gets or sets the responsibilities.
        /// </summary>
        /// <value>
        /// The responsibilities.
        /// </value>
        public string Responsibilities { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Employee"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Employee"/> is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool Deleted { get; set; }
    }
}