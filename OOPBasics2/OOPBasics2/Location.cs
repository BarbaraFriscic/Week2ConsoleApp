using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics2
{
    public class Location
    {
        public Guid Id {get; set;}
        public string Name { get; set;}
        public bool GroupTraining { get; set;}
        public bool PersonalTrainer { get; set; }
        public string Equipment { get; set; }    

        public List<Employee> Employees { get; set;}
        public List<Member> Members { get; set;}

        public Location()
        {
            
            Employees = new List<Employee>();
            Members = new List<Member>();
        }

        public override string ToString()
        {
            string dostupnostGroupTraining= "nije dostupno";
            string dostupnostPersonalTrainer = "nije dostupno";
            
            if (GroupTraining == true)
                dostupnostGroupTraining = "dostupno";
            if (PersonalTrainer == true)
                dostupnostPersonalTrainer = "dostupno";
            return $"{Id}\n{Name}\nGroup Training: {dostupnostGroupTraining}\nPersonal Trainer: {dostupnostPersonalTrainer}\nEquipment: {Equipment}";
        }
    }
}
