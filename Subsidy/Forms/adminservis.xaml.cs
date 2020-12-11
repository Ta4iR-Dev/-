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
using System.Windows.Shapes;

namespace Subsidy.Forms
{
    /// <summary>
    /// Логика взаимодействия для adminservis.xaml
    /// </summary>
    public partial class adminservis : Window
    {
        public adminservis()
        {
            InitializeComponent();
        }

        private void btgetclient_Click(object sender, RoutedEventArgs e)
        {
            Forms.Admintable admintable = new Admintable();
            admintable.Show();
            this.Close();


        }

        private void bthome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void btgetclientsubsidy_Click(object sender, RoutedEventArgs e)
        {
            Forms.Admintable2 admintable2 = new Admintable2();
            admintable2.Show();
            this.Close();
 
        }
    }
}
