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
    /// Логика взаимодействия для Remuveclient2.xaml
    /// </summary>
    public partial class Remuveclient2 : Window
    {
        public Remuveclient2()
        {
            InitializeComponent();
        }

        private void btHOme_Click(object sender, RoutedEventArgs e)
        {
            Forms.Admintable admintable = new Admintable();
            admintable.Show();
            this.Close();

        }

        private void btYES_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.DBEntities1 dBEntities1 = new DB.DBEntities1();
                {
                    int y = Convert.ToInt32(tbgetid.Text);
                    var ID = dBEntities1.Subsidy1.FirstOrDefault(x => x.id == y);
                    dBEntities1.Subsidy1.Remove(ID);
                    dBEntities1.SaveChanges();

                    MessageBox.Show("Успешно!");

                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }
    }
}
