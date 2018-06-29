using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransferLayer
{
    [XmlType("Student")]
    public class Student : Person
    {
        public Student() { }
        public Student(string name,string surname,int identifier)
        {
            Name = name;
            Surname = surname;
            Identifier = identifier;
        }
        [XmlElement("YearStudy")]
        public int YearStudy { get; set; }
    }
}
