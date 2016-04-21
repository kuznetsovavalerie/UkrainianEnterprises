using System.Collections.Generic;

namespace UkrainianEnterprises.Common
{
    /// <summary>
    /// The enterprise type represents a kind of enterprise activity
    /// </summary>
    public class EnterpriseCategory
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

        public ICollection<Document> Documents { get; set; }
    }
}