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
using System.Text.RegularExpressions;

namespace Submission_of_Applications_Shashin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            string serAndNum = SeriesAndNumberPassport.Text;
            if (RB1.IsChecked == false && RB2.IsChecked == false && RB3.IsChecked == false && RB4.IsChecked == false)
            {
                MessageBox.Show("Выберите свое образование");
                return;
            }
            if (RB5.IsChecked == false && RB6.IsChecked == false)
            {
                MessageBox.Show("Выберите документ об образовании");
                return;
            }

            if (string.IsNullOrWhiteSpace(serAndNum) || !Regex.IsMatch(serAndNum.Replace(" ", ""), @"^\d{10}$"))
            {
                MessageBox.Show("Введите серию и номер паспорта в формате SSSS NNNNNN");
                return;
            }

            if (string.IsNullOrWhiteSpace(AverageGrade.ToString()) || Regex.IsMatch(AverageGrade.ToString(), @"^\d{1,2}([.,]\d{1,2})?$"))
            {
                MessageBox.Show("Введите средний балл аттестата");
                return;
            }
            if (double.Parse(AverageGrade.Text) < 2.00 || double.Parse(AverageGrade.Text) > 5.00)
            {
                MessageBox.Show("Балл должен быть в диапазоне от 2.00 до 5.00");
                return;
            }
            this.NavigationService.Navigate(new Status());
        }
    }
}
