using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferLayer;

namespace DataLayer
{
    public interface IRepository
    {
        List<Person> GetPersonList();
        void AddPerson(Person anonim);
     
    }
}
