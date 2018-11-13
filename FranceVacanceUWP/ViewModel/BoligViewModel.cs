using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FranceVacanceUWP.Annotations;
using FranceVacanceUWP.Model;

namespace FranceVacanceUWP.ViewModel
{
    class BoligViewModel : INotifyPropertyChanged
    {
        public BoligCatalog BoligCatalog { get; set; }

        //TODO: Commands, Binding, Test serialization, GUI, RelayCommand??

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
