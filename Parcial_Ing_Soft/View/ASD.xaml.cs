using System.Windows;
using Parcial_Ing_Soft.ViewModel;

namespace Parcial_Ing_Soft.ViewModel
{
    public partial class ASD : Window
    {
        public ASD()
        {
            InitializeComponent();
        }

        private void agregar_volver_atras(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window ventana_menu = new MainWindow();
            ventana_menu.Show();
        }
    }
}
