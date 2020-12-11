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
    /// Логика взаимодействия для Admintable2.xaml
    /// </summary>
    public partial class Admintable2 : Window
    {
        public Admintable2()
        {
            InitializeComponent();
            DB.DBEntities1 dBEntities = new DB.DBEntities1();
            mainGrid.ItemsSource = dBEntities.Subsidy2.ToList();
        }

        private void BTHome_Click(object sender, RoutedEventArgs e)
        {
            Forms.adminservis adminservis = new adminservis();
            adminservis.Show();
            this.Close();

        }

        private void btremuve_Click(object sender, RoutedEventArgs e)
        {
            Forms.Remuveclient remuveclient = new Remuveclient();
            remuveclient.Show();
            this.Close();
            

        }
    }
}
