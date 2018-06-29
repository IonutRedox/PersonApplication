using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TransferLayer;
using BusinessLayer;
using UserLayer.Commands;
using UserLayer.Helper;

namespace UserLayer.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged 
    {
        public MainViewModel()
        {
            var temp = PersonManage.GetPersons();
            foreach (Person anonim in temp)
            {
                Persons.Add(anonim);
            }
            _addCommand = new RelayCommand(AddWindow_Execute, () => true);
            _editCommand = new RelayCommand(EditWindow_Execute, Command_CanExecute);
            _deleteCommand = new RelayCommand(DeleteCommand_Execute, Command_CanExecute);
            _searchCommand = new RelayCommand(SearchCommand_Execute, Search_CanExecute);
        }

        public string SearchedPerson { get; set; }
        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                OnPropertyRaised("SelectedPerson");
            }
        }
        public static bool IsFocused { get; set; }
        static private ObservableCollection<Person> _persons = new ObservableCollection<Person>();
        static public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        PersonManager PersonManage = new PersonManager();
      
        private ICommand _editCommand;
        private ICommand _addCommand;
        private ICommand _deleteCommand;
        private ICommand _searchCommand;

        public ICommand SearchCommand
        {
            get { return _searchCommand; }
        }
        public ICommand AddCommand
        {
            get { return _addCommand; }
        }
        public ICommand EditCommand
        {
            get { return _editCommand; }
        }
        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public void DeleteCommand_Execute()
        {
            Persons.Remove(SelectedPerson);
            List<Person> auxiliar = new List<Person>();
            foreach(Person anonim in Persons)
            {
                auxiliar.Add(anonim);
            }
            PersonManage.SaveList(auxiliar);
        }
        public bool Command_CanExecute()
        {
            return SelectedPerson != null;
        }
        public void EditWindow_Execute()
        {

            Windows.EditWindow editWindow = new Windows.EditWindow()
            {
                DataContext = new PersonViewModel()
                {
                    Name = SelectedPerson.Name,
                    Surname = SelectedPerson.Surname,
                    Identifier = SelectedPerson.Identifier,
                    SelectedType=SelectedPerson.GetType().ToString().Substring(14),
                    YearStudy = SelectedPerson is Student ? (SelectedPerson as Student).YearStudy : 0,
                    Grade = SelectedPerson is Teacher ? (SelectedPerson as Teacher).Grade : string.Empty
                }
            };
            editWindow.ShowDialog();
        }
        public void AddWindow_Execute()
        {
            Windows.EditWindow addWindow = new Windows.EditWindow();
            addWindow.ShowDialog();
        }
        public void SearchCommand_Execute()
        {
           bool found = false;
           foreach(Person anonim in Persons)
            {
                if(SearchedPerson==anonim.Name)
                {
                    MessageBox.Show(SearchedPerson+" was found in list.");
                    found = true;
                    break;
                }
            }
           if(found==false)
            {
                MessageBox.Show(SearchedPerson+" was not found in list.");
            }
        }
        public bool Search_CanExecute()
        {
            return true;
        }
        public static void SaveChanges(Person received)
        {
            bool found = false;
            for(int i=0;i<Persons.Count;i++)
            {
                if(Persons[i].Identifier==received.Identifier)
                {
                    found = true;
                    Persons[i] = received;
                    break;
                }
            }
            if(found==false)
            {
                Persons.Add(received);
            }
                
            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

    }
}
