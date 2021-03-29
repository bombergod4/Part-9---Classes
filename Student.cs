using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9___Classes
{
    public class Student
    {
        private static Random generator = new Random();
        private string firstName;
        private string lastName;
        private string email;
        private int studentNumber;
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            studentNumber = (555000 + generator.Next(0, 1000));
            GenerateEmail();
        }
        public string Firstname
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }

        }
        public override string ToString()
        {
            return firstName + " " + lastName + "  Student Number: " + studentNumber + "   Email:  " + email;
        }
        public void ResetStudentNumber()
        {
            studentNumber = generator.Next(0, 999) + 555000;
        }
        private void GenerateEmail()
        {
            if (firstName.Length < 3 && lastName.Length < 3)
                email = firstName + lastName + (studentNumber - 555000) +  "@ICS4U.com";
            else if (firstName.Length < 3)
                email = firstName + lastName.Substring(0, 3) + (studentNumber - 555000)+ "@ICS4U.com";
            else if (lastName.Length < 3)
                email = firstName.Substring(0, 3) + lastName + (studentNumber - 555000) + "@ICS4U.com";
            else
                email = firstName.Substring(0, 3) + lastName.Substring(0, 3) + (studentNumber - 555000) + "@ICS4U.com";
        }
        

    }
}
