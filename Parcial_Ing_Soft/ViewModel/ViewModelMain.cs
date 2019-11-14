using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Parcial_Ing_Soft.Model;
using Parcial_Ing_Soft.Helpers;
using System.Data.OleDb;

namespace Parcial_Ing_Soft.ViewModel
{
    class ViewModelMain : ViewModelBase
    {   /// <summary>
        /// Creo el view model con la coneccion a la base de datos y trae la clase del modelo y lo refleja en el view   
        /// 
        /// La base del INotifyPropertyChanged esta en el ViewModelBase
        /// 
        /// </summary>
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=inmobiliaria_2018.accdb");

        public ObservableCollection<Person> People { get; set; }

        object _SelectedPerson;
        public object SelectedPerson
        {
            get
            {
                return _SelectedPerson;
            }
            set
            {
                if (_SelectedPerson != value)
                {
                    _SelectedPerson = value;
                    RaisePropertyChanged("SelectedPerson");
                }
            }
        }

        string _TextProperty1;
        public string TextProperty1
        {
            get
            {
                return _TextProperty1;
            }
            set
            {
                if (_TextProperty1 != value)
                {
                    _TextProperty1 = value;
                    RaisePropertyChanged("TextProperty1");
                }
            }
        }

        public RelayCommand AddUserCommand { get; set; }

        public ViewModelMain()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from ((((inmueble inner join duenio on inmueble.dni_duenio1 = duenio.dni_duenio) inner join situacion on inmueble.id_situacion1 = situacion.id_situacion) inner join tipo on tipo.id_tipo = inmueble.id_tipo1) inner join zona on inmueble.id_zona = zona.id_zona)", connection);
            OleDbDataReader reader = command.ExecuteReader();
           
            People = new ObservableCollection<Person>
            {
         
            };
            while (reader.Read())
            {

                People.Add(new Person { Tipo=reader["nombre_tipo"].ToString(),Barrio=reader["nombre_zona"].ToString(),Calle=reader["calle_inmueble"].ToString(),Altura=reader["nro_calle_inmueble"].ToString(),Piso=reader["piso_inmueble"].ToString(), Situacion=reader["nombre_situacion"].ToString(), Dueño = reader["apellido_duenio"].ToString(), Precio=reader["precio_inmueble"].ToString(), Dpto=reader["nro_inmueble"].ToString(), Telefono=reader["telefono_duenio"].ToString() });
            }
            TextProperty1 = " ";

            AddUserCommand = new RelayCommand(AddUser);
        }

        void AddUser(object parameter)
        {
            if (parameter == null) return;
            People.Add(new Person { Tipo=parameter.ToString(), Dueño = parameter.ToString() });
        }

    }
}