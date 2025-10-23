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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            if (ochno.IsChecked == false && zaochno.IsChecked == false)
            {
                MessageBox.Show("Выберите форму обучения");
                return;
            }

            if (free.IsChecked == false && dogovor.IsChecked == false)
            {
                MessageBox.Show("Выберите тип обучения");
                return;
            }

            string Obr = obrOrg.Text;
            string Oconch = godOconch.Text;

            if (string.IsNullOrWhiteSpace(Obr))
            {
                MessageBox.Show("Введите сведения об образовательной организации");
                return;
            }

            if (string.IsNullOrWhiteSpace(Oconch))
            {
                MessageBox.Show("Введите год окончания образовательной организации");
                return;
            }
            try
            {
                int ocnch = int.Parse(Oconch);
                if(ocnch <= 2000 || ocnch > 2025)
                {
                    MessageBox.Show("Введите корректный год окончания образовательной организации");
                    return;
                }

            } catch 
            {
                MessageBox.Show("Введите корректный год окончания образовательной организации");
                return;
            }

            this.NavigationService.Navigate(new Education());
        }
    }
}
