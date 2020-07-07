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
using SegundoParcial_JoseLuis.UI.Registros;
using SegundoParcial_JoseLuis.UI.Consultas;

namespace SegundoParcial_JoseLuis
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rProyectosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProyectos rProyectos = new rProyectos();
            rProyectos.Show();
        }

        private void cTareasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cTareas cTareas = new cTareas();
            cTareas.Show();
        }
    }
}
