using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    public class Employee : PersonalInfo
    {
        public Guid Id { get; set; }
        public string Position { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public Guid LocationId { get; set; }

        public Location Location { get; set; }
        public LoginData LoginData { get; set; }

        public Employee(Guid id, string firstN, string lastN, string position, DateTime dateOfEmployment)
        {
            this.Location = new Location();
            this.LoginData = new LoginData();
            this.Id = id;
            this.FirstName = firstN;
            this.LastName = lastN;
            this.Position = position;
            this.DateOfEmployment = dateOfEmployment;
        }

        public string GetEmployeeInfo()
        {
            return $"Id: {Id}\nIme i prezime: {FirstName} {LastName}\nPozicija:{Position}\nZaposlen: {DateOfEmployment}";
        }
    }
}
