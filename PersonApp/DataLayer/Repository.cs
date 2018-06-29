using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using TransferLayer;

namespace DataLayer
{
    public class Repository:IRepository
    {
        public static XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        private List<Person> outList = new List<Person>();

        public void AddPerson(Person anonim)
        {
            outList.Add(anonim);
            using (FileStream filestream = new FileStream("Persons.xml", FileMode.Create))
            {
                serializer.Serialize(filestream, outList);
            }
        }

        public void SaveList(List<Person> listToSave)
        {
            using (FileStream filestream = new FileStream("Persons.xml", FileMode.Create))
            {
                serializer.Serialize(filestream, listToSave);
            }
        }

        public  List<Person> GetPersonList()
        { 
            using (FileStream filestream = new FileStream("Persons.xml", FileMode.Open))
            {
                outList =(List<Person>)serializer.Deserialize(filestream);
                return outList;
            }
        }

    }
}
