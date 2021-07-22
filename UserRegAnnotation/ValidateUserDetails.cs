using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace UserRegAnnotation
{
   
    class ValidateUserDetails
    {
        UserAnnotationFields annotationFields = new UserAnnotationFields();
        public void ValidateUser()
        {
            
            Console.Write("Enter first name :");
            annotationFields.firstName = Console.ReadLine();
            Console.Write("Enter Last name : ");
            annotationFields.lastName = Console.ReadLine();
            Console.Write("Enter Email Id : ");
            annotationFields.emailId = Console.ReadLine();
            Console.Write("Enter Phone Number :");
            annotationFields.phoneNum = Console.ReadLine();
            Console.Write("Enter Password : ");
            annotationFields.password = Console.ReadLine();
            ValidateUserAnnotationFields();
        }

        public void ValidateUserAnnotationFields()
        {
            ValidationContext validationContext = new ValidationContext(annotationFields, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(annotationFields, validationContext, validationResults, true);

            if (!isValid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            
        }
    }
}
