using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.Repos;
using Kreta.Desktop.SchoolCitizens;
using Kreta.Desktop.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{ 
    public partial class TeacherViewModel : BaseViewModel
    {
        private TeacherRepo _teacherRepo = new();

        [ObservableProperty]
        private ObservableCollection<Teacher> _teachers = new();

        [ObservableProperty]
        private Teacher _selectedTeacher = new();

        public TeacherViewModel()
        {
            UpdateView();
        }

        public void UpdateView()
        {
            List<Teacher> teachers = _teacherRepo.FindAll();
            Teachers = new ObservableCollection<Teacher>(teachers);
        }
    }
}
