using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ComidaMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> _platos;

        public ObservableCollection<Plato> Platos
        {
            get { return _platos; }
            set
            {
                _platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        public MainWindowVM()
        {
            Platos = Plato.GetSamples(@"D:\2 DAM\DINT\UD5 - Plantillas\Practicas\ut5_actv1_exe\Imagenes\");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
