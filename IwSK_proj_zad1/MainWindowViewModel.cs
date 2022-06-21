using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IwSK_proj_zad1
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public string Message { get; set; }

        public ObservableCollection<string> ReceivedList { get; } = new ObservableCollection<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
