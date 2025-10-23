using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            string homePhone = HomePhone.Text;
            string mobilePhone = MobilePhone.Text;
            string email = Email.Text;

            if (string.IsNullOrWhiteSpace(homePhone) || !Regex.IsMatch(homePhone, @"^((7|8)\d{10}|\d{10})$"))
            {
                MessageBox.Show("Введите корректный номер домашнего телефона\nДопустимые форматы:\n+7 XXX XXX-XX-XX\n8 XXX XXX-XX-XX\n7 XXX XXX-XX-XX");
                return;
            }
            if (string.IsNullOrWhiteSpace(mobilePhone) || !Regex.IsMatch(mobilePhone, @"^((7|8)\d{10}|\d{10})$"))
            {
                MessageBox.Show("Введите корректный номер мобильного телефона\nДопустимые форматы:\n+7 XXX XXX-XX-XX\n8 XXX XXX-XX-XX\n7 XXX XXX-XX-XX");
                return;
            }
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Введите корректный адрес электронной почты");
                return;
            }
            this.NavigationService.Navigate(new Parents());
        }
    }
}
