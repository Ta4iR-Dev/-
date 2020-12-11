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

namespace Subsidy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Password { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Password = "admin";
            
        }

        private void guest_Click(object sender, RoutedEventArgs e)
        {
            Forms.clientservis clientservis = new Forms.clientservis();
            clientservis.Show();
            this.Close();

        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            if (tbpass.Password == Password){
                Forms.adminservis adminservis = new Forms.adminservis();
                adminservis.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль админа");
            }
           

        }
    }
}
