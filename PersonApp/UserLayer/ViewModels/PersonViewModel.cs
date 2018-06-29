using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using TransferLayer;
using System.ComponentModel;
using System.Collections.ObjectModel;
using UserLayer.Helper;
using UserLayer.Commands;
using UserLayer;
using BusinessLayer;

namespace UserLayer.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged 
    {
     
        public PersonViewModel()
        {
    
            _saveCommand = new RelayCommand(()=>ExecuteSave(), ()=>CanExecuteSave());
        }
       
        private string[] _types = { "Student", "Teacher" };
        public string[] Types
        {
            get { return _types; }
        }
        private string _selectedType;
        public string SelectedType
        {
            get { return _selectedType; }
            set
            {
                _selectedType = value;
                OnPropertyChanged("SelectedType");
            }
        }
        private int _identifier = GetIdentifier();
        public int Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Grade { get; set; }
        public int YearStudy { get; set; }
        private bool? _dialogResult;
        public bool? DialogResult
        {
            get { return _dialogResult; }
            private set
            {
                _dialogResult = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DialogResult)));
            }
        }
        private ICommand _saveCommand;
        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        public void ExecuteSave()
        {
            DialogResult = true;
            Student student = new Student(Name,Surname,Identifier);
            Teacher teacher = new Teacher(Name,Surname,Identifier);
            if(SelectedType=="Student")
            { 
                student.YearStudy = YearStudy;
                MainViewModel.SaveChanges(student);
            }
            else
            {
                teacher.Grade = Grade;
                MainViewModel.SaveChanges(teacher);
            }
            
        }
        private bool CanExecuteSave()
        {
            if (ValidFields())
            {
                return true;
            }
            return false;
        }
        public static int GetIdentifier()
        {
            Random random = new Random();
            int generated = random.Next(1, 1000);
            return generated;
        }
        public  bool ValidFields()
        {
            if (string.IsNullOrEmpty(Name) == false && string.IsNullOrWhiteSpace(Name)==false && string.IsNullOrWhiteSpace(Surname) == false && string.IsNullOrEmpty(Surname) == false )
            {
                if(SelectedType=="Student" && YearStudy!=0 && string.IsNullOrEmpty(YearStudy.ToString())==false )
                {
                    return true;
                }
                else if(SelectedType=="Teacher" && string.IsNullOrEmpty(Grade)==false)
                {
                    return true;
                }
            }
            return false;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }

}
