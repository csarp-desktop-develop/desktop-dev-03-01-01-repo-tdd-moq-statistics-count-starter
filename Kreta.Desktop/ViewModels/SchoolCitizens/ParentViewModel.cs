using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.Repos;
using Kreta.Desktop.SchoolCitizens;
using Kreta.Desktop.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class ParentViewModel : BaseViewModel
    {
        private ParentRepo _parentRepo=new();

        [ObservableProperty]
        private ObservableCollection<Parent> _parents=new();

        [ObservableProperty]
        private Parent _selectedParent = new();

        public ParentViewModel()
        {
            UpdateView();
        }

        public void UpdateView()
        {
            List<Parent> parents=_parentRepo.FindAll();
            Parents=new ObservableCollection<Parent>(parents);
        }
    }
}
