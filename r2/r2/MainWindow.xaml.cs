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

namespace r2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CommentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())

            {
                try
                {
                    
                        cliente.guardar(Int32.Parse(TextBox1.Text), TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);
                    }
                      catch (Exception)
                {
                    MessageBox.Show("No hay datos para registrar");
                }
            }
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.SelectedDate = null;
            TextBox4.SelectedDate = null;
            TextBox5.Clear();
            TextBox6.Clear();
        }
        

        private void btneditar_Click(object sender, RoutedEventArgs e)
        {
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                    cliente.modificar(Int32.Parse(TextBox1.Text), TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);
                MessageBox.Show("Elemento modificado");   
                TextBox1.Clear();
                TextBox2.Clear();
                TextBox3.SelectedDate = null;
                TextBox4.SelectedDate = null;
                TextBox5.Clear();
                TextBox6.Clear();

            }
                catch (Exception)
                {
                    MessageBox.Show("Seleccione los datos a modificar");
                }
            }
        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            string[] vector = new string[5];
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                    vector = cliente.buscar(Int32.Parse(TextBox1.Text));
                    if (vector[0] == null)
                    {
                        MessageBox.Show("No se encuentra");
                    }
                        TextBox2.Text = vector[1];
                        TextBox3.Text = vector[2];
                        TextBox4.Text = vector[3];
                        TextBox5.Text = vector[4];
                        TextBox6.Text = vector[5];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha especificado una clave");
                }
            }
        }

        private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                    if (cliente.eliminar(Int32.Parse(TextBox1.Text)))
                    {
                        MessageBox.Show("Registro eliminado");
                        TextBox1.Clear();
                        TextBox2.Clear();
                        TextBox3.SelectedDate = null;
                        TextBox4.SelectedDate = null;
                        TextBox5.Clear();
                        TextBox6.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No existe");
                    }
                }
                catch
                {
                    MessageBox.Show("No hay datos que eliminar");
                }
            }
        }
    }
}

