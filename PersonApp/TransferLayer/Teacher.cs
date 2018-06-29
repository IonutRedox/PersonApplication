using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransferLayer
{
    [XmlType("Teacher")]
    public class Teacher : Person
    {
        public Teacher() { }
        public Teacher(string name,string surname,int identifier)
        {
            Name = name;
            Surname = surname;
            Identifier = identifier;
        }
        [XmlElement("Grade")]
        public string Grade { get; set; }
    }
}
