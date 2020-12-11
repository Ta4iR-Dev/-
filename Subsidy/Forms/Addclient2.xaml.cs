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
    /// Логика взаимодействия для Addclient2.xaml
    /// </summary>
    public partial class Addclient2 : Window
    {
        DB.Subsidy2 newSubsidy;
        public Addclient2()
        {
            InitializeComponent();
            DB.DBEntities1 dBEntities = new DB.DBEntities1();
            newSubsidy = new DB.Subsidy2();
            mainGrid.DataContext = newSubsidy;
        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            Forms.clientservis clientservis = new clientservis();
            clientservis.Show();
            this.Close();

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            newSubsidy = mainGrid.DataContext as DB.Subsidy2;

            newSubsidy.Фамилия_родитель_ = tbfirstnameR.Text;
            newSubsidy.Имя_родитель_ = tblastnameR.Text;
            newSubsidy.Отчество_родитель_ = tbPhotomaticR.Text;
            newSubsidy.Серия_паспорта_ = tbseriaP.Text;
            newSubsidy.Номер_паспотра_ = tbnamberP.Text;
            newSubsidy.Тип__паспотр_РФ_Иностранный__ = tbtupP.Text;
            newSubsidy.Фамилия_ребенок_ = tbfirstnameReb.Text;
            newSubsidy.Имя_ребенок_ = tblastnameReb.Text;
            newSubsidy.Отчество_ребенок_ = tbPhotomaticReb.Text;
            newSubsidy.Серия_свидетельство_о_рожд__ = tbseriaS.Text;
            newSubsidy.Номер_свидетельство_о_рожд__ = tbnamberS.Text;
            newSubsidy.Тип_РФ_Иностранный_ = tbtupS.Text;
            newSubsidy.дата_рождения_ребенок_ = dp.SelectedDate;
            newSubsidy.Номер_телефона = tbnamberfhone.Text;
            newSubsidy.Почта = tbpochta.Text;


            try
            {
                DB.DBEntities1 dBEntities1 = new DB.DBEntities1();
                {
                    dBEntities1.Subsidy2.Add(newSubsidy);

                    dBEntities1.SaveChanges();
                }

                MessageBox.Show("Сохранение прошло  успешно");

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
