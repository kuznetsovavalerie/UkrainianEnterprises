using System.Collections.Generic;

namespace UkrainianEnterprises.Common
{
    /// <summary>
    /// The Department inside single location
    /// </summary>
    public class Department
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
        /// The official title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The short description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the offices.
        /// </summary>
        /// <value>
        /// The offices.
        /// </value>
        public ICollection<Office> Offices { get; set; }

        /// <summary>
        /// Gets or sets the given documents.
        /// </summary>
        /// <value>
        /// The given documents.
        /// </value>
        public ICollection<Document> GivenDocuments { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}