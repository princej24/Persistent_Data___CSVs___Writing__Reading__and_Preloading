using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Persistent_Data___CSVs___Writing__Reading__and_Preloading
{
    public class Student
    {
        string _Firstname;
        string _LastName;
        int genEdGrade;
        int csiGrade;

        public Student()
        {

        }


        public Student(string firstname, string lastName, int genEdGrade, int csiGrade)
        {
            _Firstname = firstname;
            _LastName = lastName;
            this.genEdGrade = genEdGrade;
            this.csiGrade = csiGrade;
        }

        public string Firstname { get => _Firstname; set => _Firstname = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public int GenEdGrade { get => genEdGrade; set => genEdGrade = value; }
        public int CsiGrade { get => csiGrade; set => csiGrade = value; }
    }
    
}
