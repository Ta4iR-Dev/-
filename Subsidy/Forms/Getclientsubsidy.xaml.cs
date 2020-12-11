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
    /// Логика взаимодействия для Getclientsubsidy.xaml
    /// </summary>
    public partial class Getclientsubsidy : Window
    {
        public Getclientsubsidy()
        {
            InitializeComponent();
            DB.DBEntities1 dBEntities1 = new DB.DBEntities1();
            mainGrid.ItemsSource = dBEntities1.Subsidy2.ToList();
        }

        private void BTHome_Click(object sender, RoutedEventArgs e)
        {
            Forms.clientservis clientservis = new clientservis();
            clientservis.Show();
            this.Close();

        }
    }
}
