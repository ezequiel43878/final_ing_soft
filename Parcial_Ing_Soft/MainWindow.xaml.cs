using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Parcial_Ing_Soft.ViewModel;

namespace Parcial_Ing_Soft
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       /* private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Parcial_Ing_Soft.inmobiliariaDataSet inmobiliariaDataSet = ((Parcial_Ing_Soft.inmobiliariaDataSet)(this.FindResource("inmobiliariaDataSet")));
            // Cargar datos en la tabla inmueble. Puede modificar este código según sea necesario.
            Parcial_Ing_Soft.inmobiliariaDataSetTableAdapters.inmuebleTableAdapter inmobiliariaDataSetinmuebleTableAdapter = new Parcial_Ing_Soft.inmobiliariaDataSetTableAdapters.inmuebleTableAdapter();
            inmobiliariaDataSetinmuebleTableAdapter.Fill(inmobiliariaDataSet.inmueble);
            System.Windows.Data.CollectionViewSource inmuebleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("inmuebleViewSource")));
            inmuebleViewSource.View.MoveCurrentToFirst();
        }
        */
        private void Button_MouseWheel(object sender, MouseWheelEventArgs e)
        {

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
           
        }

        private void agregar_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }

        private void agregar_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void agregar_inmueble(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window ventana_agregar = new agregar_inmueble();
            ventana_agregar.Show();
        }

        private void listar1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window listar1 = new listar1();
            listar1.Show();
        }

        private void prueba(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window prueba = new prueba();
            prueba.Show();
        }

        private void buscar_mvvm(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window listar1 = new ASD();
            listar1.Show();
        }
    }
}
