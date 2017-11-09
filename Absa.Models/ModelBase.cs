using System;

namespace Absa.Models
{
    /// <summary>
    /// Represent the model base class.
    /// </summary>
    public abstract class ModelBase
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>The modified date.</value>
        public DateTime ModifiedDate { get; set; }
    }
}