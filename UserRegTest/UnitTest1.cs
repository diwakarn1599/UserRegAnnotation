using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegAnnotation;
using System;
namespace UserRegTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void ObjectCreationUsingReflection()
        {
            ValidateUserDetails validation = new ValidateUserDetails();
            object obj = null;
            try
            {
                UserRegFactory urf = new UserRegFactory();
                obj = urf.CreateUserObject("UserRegAnnotation.ValidateUserDetails", "ValidateUserDetails");
                obj.Equals(validation);
            }
            catch (UserRegCustomException ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        [TestMethod]
        public void ReflectionTestSetField()
        {
            string expected = "Validating user details";
            UserRegFactory urf = new UserRegFactory();
            string actual = urf.SetField(expected, "message");
            Assert.AreEqual(expected, actual);
        }
    }
}
