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

namespace Submission_of_Applications_Shashin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Speciality.xaml
    /// </summary>
    public partial class Speciality : Page
    {
        public Speciality()
        {
            InitializeComponent();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            int countSpecialization = 0;
            for(int i = 1; i <= 13; i++)
            {
                string checkboxName = "CB" + i;
                CheckBox checkBox = (CheckBox)this.FindName(checkboxName);
                if(checkBox.IsChecked == true) 
                    countSpecialization++;
            }
            if (countSpecialization > 5)
            {
                MessageBox.Show("Выбрано больше 5 специальностей");
                return;
            }
            if(countSpecialization == 0)
            {
                MessageBox.Show("Выберите хотя бы 1 специальность");
                return;
            }
            if(RB1.IsChecked == false && RB2.IsChecked == false)
            {
                MessageBox.Show("Выберите в какой раз вы получаете СПО");
                return;
            }
            if (cB1.IsChecked == false || cB2.IsChecked == false)
            {
                MessageBox.Show("Согласитесь с условиями");
                return;
            }
            this.NavigationService.Navigate(new Passport());
        }
    }
}
