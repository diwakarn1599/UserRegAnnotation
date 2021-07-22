using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserRegAnnotation
{
    class UserAnnotationFields
    {
        /// <summary>
        /// validation of first name using annotation
        /// </summary>
        [Required(ErrorMessage = "first name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name should be minimum 3 characters")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}", ErrorMessage = "First name is Invalid")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }
        /// <summary>
        /// validation of last name using annotation
        /// </summary>
        [Required(ErrorMessage = "lastname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name should be minimum 3 characters")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}", ErrorMessage = "last name is Invalid")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }
        /// <summary>
        /// validation of email using annotation
        /// </summary>
        [Required(ErrorMessage = "email is required")]
        [RegularExpression(@"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2})?$", ErrorMessage = "Email id is invalid")]
        [DataType(DataType.EmailAddress)]
        public string emailId { get; set; }

        /// <summary>
        /// validation of phone number using annotation
        /// </summary>
        [Required(ErrorMessage = "phone number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[1-9]{2}[ ][0-9]{10}$", ErrorMessage = "Phone Number is invalid")]
        [Phone]
        public string phoneNum { get; set; }

        /// <summary>
        /// validation of password using annotation
        /// </summary>
        [Required(ErrorMessage = "password is required")]
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Passsword is invalid")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}

