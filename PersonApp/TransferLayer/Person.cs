using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TransferLayer
{
    [XmlRoot("Person")]
    [XmlInclude(typeof(Student)), XmlInclude(typeof(Teacher))]
    public abstract class Person 
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Surname")]
        public string Surname { get; set; }
        [XmlElement("Identifier")]
        public int Identifier { get; set; }
    }
}
