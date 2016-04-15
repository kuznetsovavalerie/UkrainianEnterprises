using System;
using System.Collections.Generic;

namespace UkrainianEnterprises.BLL
{
    /// <summary>
    /// Document needed to request in enterprises,
    /// contains short information about it and about places, where to get it.
    /// 
    /// </summary>
    public class Document
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
        /// The official document title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The short description of document content.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the dependecies.
        /// </summary>
        /// <value>
        /// The another documents needed to get current document.
        /// </value>
        public ICollection<Document> Dependecies { get; set; }

        /// <summary>
        /// Gets or sets the enterprise types.
        /// </summary>
        /// <value>
        /// The enterprise types, which are able to give such documents.
        /// </value>
        public ICollection<EnterpriseType> EnterpriseTypes { get; set; }

        /// <summary>
        /// Gets or sets the enterprises.
        /// </summary>
        /// <value>
        /// The enterprises, which are able to give such documents.
        /// </value>
        public ICollection<Enterprise> Enterprises { get; set; }

        /// <summary>
        /// Gets or sets the departments.
        /// </summary>
        /// <value>
        /// The departments, which are able to give such documents.
        /// </value>
        public ICollection<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the offices.
        /// </summary>
        /// <value>
        /// The offices, which are able to give such documents.
        /// </value>
        public ICollection<Office> Offices { get; set; }
    }
}