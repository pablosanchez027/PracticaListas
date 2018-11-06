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

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Alumnos> alumnos = new List<Alumnos>();

        public MainWindow()
        {
            InitializeComponent();
            alumnos.Add(new Alumnos("Sofía Beltrán Matrín", "179156", "Ing. En Ser Bonita y Lista"));
            alumnos.Add(new Alumnos("Angela Merkel", "198110", "Ing. Quimica"));
            alumnos.Add(new Alumnos("Betín Riverga", "171697", "Ing. Prietismo"));
            alumnos.Add(new Alumnos("Sir Pablo Sánchez", "139028", "Ing. en Producción Multimedia"));

            foreach (Alumnos alumno in alumnos)
            {
                lstAlumnos.Items.Add(new ListBoxItem() {

                    Content = alumno.Nombre

                });
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
        }
    }
}
