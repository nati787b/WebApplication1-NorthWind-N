// Written by Nathnael Tegegne
// 10/21/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1_NorthWind_N.Models
{
    public class Employee
    {
        // class variables
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        // gets and sets
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1)
                { this.employeeId = value; }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }
            set
            {
                if (value > -1)
                { this.reportsTo = value; }
            }
        }

        // constructors
        public Employee() : this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a","n/a","n/a","n/a", -1)
        {
            //empty constructor
        }
        public Employee(string aLastname) : this(-1, aLastname, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a","n/a", -1)
        {
            //partial constructor
        }
        public Employee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy,
            string aBirthDate, string aHiredate, string aAddress, string aCity, string aRegion,string aPostalCode,string aCountry, string aHomePhone, string aExtension, string aNotes
            , int aReportsTo)
        {
            this.EmployeeId = aEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHiredate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo;
        }
        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "EmployeeId:" + this.EmployeeId + "\n";
            msg = msg + "LastName:" + this.LastName + "\n";
            msg = msg + "FirstName:" + this.FirstName + "\n";
            msg = msg + "Title:" + this.Title + "\n";
            msg = msg + "TitleOfCourtesy:" + this.TitleOfCourtesy + "\n";
            msg = msg + "BirthDate:" + this.BirthDate + "\n";
            msg = msg + "HireDate:" + this.HireDate + "\n";
            msg = msg + "Address:" + this.Address + "\n";
            msg = msg + "City:" + this.City + "\n";
            msg = msg + "Region:" + this.Region + "\n";
            msg = msg + "PostalCode:" + this.PostalCode + "\n";
            msg = msg + "Country:" + this.Country + "\n";
            msg = msg + "HomePhone:" + this.HomePhone + "\n";
            msg = msg + "Extension:" + this.Extension + "\n";
            msg = msg + "Notes:" + this.Notes + "\n";
            msg = msg + "ReportsTo:" + this.ReportsTo + "\n";
            return msg;
        }
    }
}
