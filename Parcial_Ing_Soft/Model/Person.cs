using System;
using System.ComponentModel;

namespace Parcial_Ing_Soft.Model
{      /// <summary>
       ///   Aqui creo la clase con los campos del inmueble
       /// </summary>
    public class Person : INotifyPropertyChanged
    {
        string _Tipo;
        public string Tipo
        {
            get
            {
                return _Tipo;
            }
            set
            {
                if (_Tipo != value)
                {
                    _Tipo = value;
                    RaisePropertyChanged("Tipo");
                }
            }
        }

        string _Barrio;
        public string Barrio
        {
            get
            {
                return _Barrio;
            }
            set
            {
                if (_Barrio != value)
                {
                    _Barrio = value;
                    RaisePropertyChanged("Barrio");
                }
            }
        }

        string _Calle;
        public string Calle
        {
            get
            {
                return _Calle;
            }
            set
            {
                if (_Calle != value)
                {
                    _Calle = value;
                    RaisePropertyChanged("Calle");
                }
            }
        }

        string _Altura;
        public string Altura
        {
            get
            {
                return _Altura;
            }
            set
            {
                if (_Altura != value)
                {
                    _Altura = value;
                    RaisePropertyChanged("Altura");
                }
            }
        }

        string _Piso;
        public string Piso
        {
            get
            {
                return _Piso;
            }
            set
            {
                if (_Piso != value)
                {
                    _Piso = value;
                    RaisePropertyChanged("Piso");
                }
            }
        }

        string _Dpto;
        public string Dpto
        {
            get
            {
                return _Dpto;
            }
            set
            {
                if (_Dpto != value)
                {
                    _Dpto = value;
                    RaisePropertyChanged("Dpto");
                }
            }
        }


        string _Dueño;
        public string Dueño
        {
            get
            {
                return _Dueño;
            }
            set
            {
                if (_Dueño != value)
                {
                    _Dueño = value;
                    RaisePropertyChanged("Dueño");
                }
            }
        }

        string _Telefono;
        public string Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                if (_Telefono != value)
                {
                    _Telefono = value;
                    RaisePropertyChanged("Telefono");
                }
            }
        }

        string _Situacion;
        public string Situacion
        {
            get
            {
                return _Situacion;
            }
            set
            {
                if (_Situacion != value)
                {
                    _Situacion = value;
                    RaisePropertyChanged("Situacion");
                }
            }
        }

        string _Precio;
        public string Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                if (_Precio != value)
                {
                    _Precio = value;
                    RaisePropertyChanged("Precio");
                }
            }
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
