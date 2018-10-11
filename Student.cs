using System;
namespace InClassAssignment
{
    public class Student
    {
        public int ID {get; set;}
        public string PhoneNumber {get;set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Role {get; set;}

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}