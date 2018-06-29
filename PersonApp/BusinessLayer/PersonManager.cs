using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferLayer;
using DataLayer;

namespace BusinessLayer
{
    public class PersonManager 
    {
        Repository MyRepository = new Repository();
        
        private bool ValidPerson(Person person)
        {
            if(person.Name!=null && person.Surname!=null && person.Identifier!=0 )
            {
                return true;
            }
            return false;
        }

        private bool ValidStudent(Student student)
        {
            if (student.YearStudy!=0  && ValidPerson(student)==true )
            {
                return true;
            }
            return false;
        }

        private bool ValidTeacher(Teacher teacher)
        {
            if(teacher.Grade!=null && ValidPerson(teacher)==true)
            {
                return true;
            }
            return false;
        }
        
        private void AddPerson(Person anonim)
        {
            if(ValidPerson(anonim))
            {
                var student = (Student)anonim;
                var teacher = (Teacher)anonim;
                if (ValidStudent(student) || ValidTeacher(teacher) ) 
                {
                    MyRepository.AddPerson(anonim);
                }
            }
        }

        public void SaveList(List<Person> listToSave)
        {
            MyRepository.SaveList(listToSave);
        }

        public List<Person> GetPersons()
        {
            return MyRepository.GetPersonList();
        }

    }
}
