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

namespace Registro
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alunno> classe;
        public MainWindow()
        {
            InitializeComponent();

            classe = new List<Alunno>();

        }

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            Alunno a = new Alunno(txtNome.Text, txtCognome.Text);
            classe.Add(a);

        }
    }

    class Alunno
    {
        string nome, cognome;
        public Alunno (string n, string c)
        {
            nome = n;  
            cognome = c;
        }

    }
}
