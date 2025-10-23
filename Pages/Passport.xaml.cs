using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Passport.xaml
    /// </summary>
    public partial class Passport : Page
    {
        public Passport()
        {
            InitializeComponent();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string dateBirth = DateOfBirth.Text;
            string citizenship = Сitizenship.Text;
            string placeBirth = PlaceOfBirth.Text;
            string seriesNumber = SeriesAndNumber.Text;
            string dateIssued = DateOfIssued.Text;
            string departamentCode = DepartamentCode.Text;
            string issued = Issued.Text;
            string regAddress = RegisteredAddress.Text;
            string district = District.Text;
            string factAddress = FacticAddress.Text;
            string factDistrict = FacticDisrtict.Text;
            if(string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[а-яА-Я]+(?:-[а-яА-Я]+)*$"))
            {
                MessageBox.Show("Введите корректное имя");
                return;
            }
            if (string.IsNullOrWhiteSpace(firstName) || !Regex.IsMatch(name, @"^[а-яА-Я]+(?:-[а-яА-Я]+)*$"))
            {
                MessageBox.Show("Введите корректную фамилию");
                return;
            }
            if (string.IsNullOrWhiteSpace(dateBirth) || !Regex.IsMatch(dateBirth, @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.\d{4}$"))
            {
                MessageBox.Show("Введите дату рождения в формате дд.мм.гггг");
                return;
            }
            if (string.IsNullOrWhiteSpace(citizenship) || !Regex.IsMatch(citizenship, @"^[а-яА-Я]*$"))
            {
                MessageBox.Show("Введите корректное гражданство");
                return;
            }
            if (string.IsNullOrWhiteSpace(placeBirth) || !Regex.IsMatch(placeBirth, @"^[а-яА-Я]*$"))
            {
                MessageBox.Show("Введите корректное место рождения");
                return;
            }
            if (string.IsNullOrWhiteSpace(seriesNumber) || !Regex.IsMatch(seriesNumber.Replace(" ", ""), @"^\d{10}$"))
            {
                MessageBox.Show("Введите серию и номер паспорта в формате SSSS NNNNNN");
                return;
            }
            if (string.IsNullOrWhiteSpace(dateIssued) || !Regex.IsMatch(dateIssued, @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.\d{4}$"))
            {
                MessageBox.Show("Введите дату выдачи в формате дд.мм.гггг");
                return;
            }
            if (string.IsNullOrWhiteSpace(departamentCode) || !Regex.IsMatch(departamentCode, @"^\d{3}-\d{3}$"))
            {
                MessageBox.Show("Введите код подразделения в формате NNN-NNN");
                return;
            }
            if (string.IsNullOrWhiteSpace(issued) || !Regex.IsMatch(issued, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректный орган, выдавший паспорт");
                return;
            }
            if (string.IsNullOrWhiteSpace(regAddress) || !Regex.IsMatch(regAddress, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректный адрес проживания");
                return;
            }
            if (string.IsNullOrWhiteSpace(district) || !Regex.IsMatch(district, @"^[а-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("Введите корректный район проживания по прописке");
                return;
            }
            if (string.IsNullOrWhiteSpace(factAddress) || !Regex.IsMatch(factAddress, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректный адрес фактического проживания");
                return;
            }
            if (string.IsNullOrWhiteSpace(factDistrict) || !Regex.IsMatch(factDistrict, @"^[а-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("Введите корректный район фактического проживания");
                return;
            }
            this.NavigationService.Navigate(new Contacts());
        }
    }
}
