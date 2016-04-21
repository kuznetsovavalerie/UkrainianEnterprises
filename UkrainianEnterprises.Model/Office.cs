using System.Collections.Generic;

namespace UkrainianEnterprises.Common
{
    /// <summary>
    /// Signed room or space in the location building, 
    /// suited to enterprise activity uses
    /// </summary>
    public class Office
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The identifier of location it situated in.
        /// </value>
        public int LocationID { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the decription.
        /// </summary>
        /// <value>
        /// The short decription of office activity.
        /// </value>
        public string Decription { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}