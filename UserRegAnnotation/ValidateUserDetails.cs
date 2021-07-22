using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace UserRegAnnotation
{
   
    public class ValidateUserDetails
    {
        public string message;
        UserAnnotationFields annotationFields = new UserAnnotationFields();

        public ValidateUserDetails(string message)
        {
            this.message = message;
        }
        public ValidateUserDetails()
        {
            
        }
        public void ValidateUser()
        {
            //Read input from user and store it in object
            
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
            //validate object
            ValidationContext validationContext = new ValidationContext(annotationFields, null, null);
            //List for error messages
            List<ValidationResult> validationResults = new List<ValidationResult>();
            //return whether validation is correct or not
            bool isValid = Validator.TryValidateObject(annotationFields, validationContext, validationResults, true);

            if (!isValid)
            {
                //if invalid print error messages
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            
        }
    }
}
