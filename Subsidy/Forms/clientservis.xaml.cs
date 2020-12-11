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
    /// Логика взаимодействия для clientservis.xaml
    /// </summary>
    public partial class clientservis : Window
    {
        public clientservis()
        {
            InitializeComponent();
        }

        private void btzaevlenie_Click(object sender, RoutedEventArgs e)
        {
            Forms.Addclient1 addclient1 = new Addclient1();
            addclient1.Show();
            this.Close();

        }

        private void btzaevlenie1_Click(object sender, RoutedEventArgs e)
        {
            Forms.Addclient2 addclient2 = new Addclient2();
            addclient2.Show();
            this.Close();

        }

        private void bthome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void btgetclient_Click(object sender, RoutedEventArgs e)
        {
            Forms.Getclientsubsidy getclientsubsidy = new Getclientsubsidy();
            getclientsubsidy.Show();
            this.Close();

        }
    }
}
