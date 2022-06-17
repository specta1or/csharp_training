using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class Contact
    {
        string firstName;
        string middleName;
        string lastName;
        string nickName;
        string title;
        string company;
        string address;
        string home;
        string mobile;
        string work;
        string fax;
        string email, email2, email3;
        string homePage;
        
         

        public Contact(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Company
        {
            get { return company; }
            set
            {
                company = value;
            }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Home
        {
            get { return home; }
            set { home = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public string Work
        {
            get { return work; }
            set { work = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Email
        { 
            get { return email; }
            set { email = value; }
        }

        public string Email2
        {
            get { return email2; }
            set { email2 = value; }
        }

        public string Email3
        {
            get { return email3; }
            set { email3 = value; }
        }

        public string HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }
    }
}
