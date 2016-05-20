namespace UkrainianEnterprises.Common.Entities
{
    /// <summary>
    /// The employee position common for all enterprises
    /// </summary>
    public class Position
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
        /// The official position title.
        /// </value>
        public int Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The full description with employee responsibilities.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level of position importance.
        /// </value>
        public PositionLevel Level { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Position"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        public bool Approved { get; set; }
    }
}