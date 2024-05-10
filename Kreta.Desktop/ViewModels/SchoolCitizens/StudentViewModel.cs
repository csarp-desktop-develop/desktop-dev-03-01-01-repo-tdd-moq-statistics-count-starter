using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.Repos;
using Kreta.Desktop.SchoolCitizens;
using Kreta.Desktop.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : BaseViewModel
    {
        private readonly EducationLevelsRepo _educationLevelsRepo = new();
        private readonly StudentRepo _studentRepo = new();

        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new();

        [ObservableProperty]
        private ObservableCollection<Student> _students = new();

        [ObservableProperty]
        private Student _selectedStudent;        
        
        public StudentViewModel()
        {
            _selectedStudent = new Student();
            UpdateView();
        }

        private void UpdateView()
        {
            EducationLevels = new ObservableCollection<string>(_educationLevelsRepo.FindAll().Select(el => el.EducationLevelName));
            Students = new ObservableCollection<Student>(_studentRepo.FindAll());
        }
    }
}
