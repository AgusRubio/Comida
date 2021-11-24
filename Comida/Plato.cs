using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace ComidaMVVM
{
    class Plato : INotifyPropertyChanged
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        private string _imagen;

        public string Imagen
        {
            get { return _imagen; }
            set
            {
                if (_imagen != value)
                {
                    _imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }

        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (_tipo != value)
                {
                    _tipo = value;
                    this.NotifyPropertyChanged("Tipo");
                }
            }
        }

        private bool _gluten;

        public bool Gluten
        {
            get { return _gluten; }
            set
            {
                if (_gluten != value)
                {
                    _gluten = value;
                    this.NotifyPropertyChanged("Gluten");
                }
            }
        }

        private bool _soja;

        public bool Soja
        {
            get { return _soja; }
            set
            {
                if(_soja != value)
                {
                    _soja = value;
                    this.NotifyPropertyChanged("Soja");
                }
            }
        }

        private bool _leche;

        public bool Leche
        {
            get { return _leche; }
            set
            {
                if(_leche != value)
                {
                    _leche = value;
                    this.NotifyPropertyChanged("Leche");
                }
            }
        }

        private bool _sulfitos;

        public bool Sulfitos
        {
            get { return _sulfitos; }
            set
            {
                if(_sulfitos != value)
                {
                    _sulfitos = value;
                    this.NotifyPropertyChanged("Sulfitos");
                }
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


