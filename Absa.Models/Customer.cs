using System;
using System.ComponentModel.DataAnnotations;

namespace Absa.Models
{
    /// <summary>
    /// Represents the Customer model class. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Absa.Models.ModelBase" />
    public sealed class Customer : ModelBase
    {
        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>The surname.</value>       
        public string Surname
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the first names.
        /// </summary>
        /// <value>The first names.</value>       
        public string FirstNames
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the identity.
        /// </summary>
        /// <value>The type of the identity.</value>       
        public string IdentityType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the identity number.
        /// </summary>
        /// <value>The identity number.</value>       
        public string IdentityNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>The date of birth.</value>       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth
        {
            get;
            set;
        }
    }
}