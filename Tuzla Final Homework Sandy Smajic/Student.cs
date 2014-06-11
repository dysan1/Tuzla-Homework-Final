using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuzla_Final_Homework_Sandy_Smajic
{
    class Student : Person, IComparable<Student>
    {
        // It automatically adds property email
        public string email { get; set; }

        private string location;

        // Complete setName mathod to check if string is valid. If it is set name field and return true

        public bool setName(string input)
        {
            if (input.Length < 2)
            {
                Console.WriteLine("Name must be at least two characters long");
                return false;
            }

            if (!input.All(Char.IsLetter))
            {
                Console.WriteLine("Name can only have letters");
                return false;
            }

            if (input.Substring(0, 1) == input[0].ToString().ToUpper())
            {
                Console.WriteLine("Name must start with an uppercase letter"); return false;
            }

            name = input;
            return true;

        }

        // Write getStudentInfo returns students name, lastName, email and location

        public string getStudentInfo()
        {
            return getPersonInfo() + ", " + email + ", " + location;
        }

        public string Location  //Indicates the Location
        {
            set
            {

                if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo")
                    location = "SA";

                if (value == "TZ" || value == "TUZLA" || value == "Tuzla")
                    location = "TZ";

                location = "NA";
            }

            get
            {
                if (location == "TZ")
                    return "Tuzla";
                if (location == "SA")
                    return "Sarajevo";

                return "NA";

            }
        }

        // It writes Student constructor that takes in three arguments name,lastName, email 

        public Student(string name, string lastName, string email)
            : base(name, lastName)
        {
            this.email = email;
        }

        // It writes Student that takes three string arguments name, lastName, locaion

        public Student(string name, string lastName, string location)
            : base(name, lastName)
        {
            this.location = location;
        }

        // Parameterless constructor
        public Student()
            : base()
        {

        }

        // Students can be sorted by location in following order by implementing IComparable

        public int CompareTo(Student b)
        {
            // It sorts everything alphabetically
            return this.name.CompareTo(b.name);
        }


        ~Student()
        {

        }

        // Override ToString() method to return Student info (return same value as getStudentInfo)

        public override string ToString()
        {
            return getStudentInfo();
        }



    }
}
