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
    /// Логика взаимодействия для Parents.xaml
    /// </summary>
    public partial class Parents : Page
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            string FioMother = FIOM.Text;
            string DateBirthMother = DOBM.Text;
            string PlaceWorkMother = POWM.Text;
            string JobTitleMother = JTM.Text;
            string PlaceLifeMother = POLM.Text;
            string HomePhoneMother = HPM.Text;
            string MobilePhoneMother = MPM.Text;

            string FioFather = FIOF.Text;
            string DateBirthFather = DOBF.Text;
            string PlaceWorkFather = POWF.Text;
            string JobTitleFather = JTF.Text;
            string PlaceLifeFather = POLF.Text;
            string HomePhoneFather = HPF.Text;
            string MobilePhoneFather = MPF.Text;

            if(string.IsNullOrWhiteSpace(FioMother) || !Regex.IsMatch(FioMother, @"^[а-яА-ЯёЁ]{2,}(?:\s+[а-яА-ЯёЁ]{2,}){1,2}$"))
            {
                MessageBox.Show("Введите корректное ФИО матери");
                return;
            }
            if (string.IsNullOrWhiteSpace(DateBirthMother) || !Regex.IsMatch(DateBirthMother, @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.\d{4}$"))
            {
                MessageBox.Show("Введите корректную дату рождения матери");
                return;
            }
            if (string.IsNullOrWhiteSpace(PlaceWorkMother) || !Regex.IsMatch(PlaceWorkMother, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректное место работы матери");
                return;
            }
            if (string.IsNullOrWhiteSpace(JobTitleMother) || Regex.IsMatch(JobTitleMother, @"^[а-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("Введите корректную должность матери");
                return;
            }
            if (string.IsNullOrWhiteSpace(PlaceLifeMother) || !Regex.IsMatch(PlaceLifeMother, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректное место жительства матери");
                return;
            }
            if (!string.IsNullOrWhiteSpace(HomePhoneMother) && !Regex.IsMatch(HomePhoneMother, @"^((7|8)\d{10}|\d{10})$"))
            {
                MessageBox.Show("Введите корректный домашний номер матери");
                return;
            }
            if (!string.IsNullOrWhiteSpace(MobilePhoneMother) && !Regex.IsMatch(MobilePhoneMother, @"^((7|8)\d{10}|\d{10})$"))
            {
                MessageBox.Show("Введите корректный мобильный номер матери");
                return;
            }
            if(CB1.IsChecked == false || CB2.IsChecked == false)
            {
                MessageBox.Show("Согласитесь на передачу данных третьим лицам");
                return;
            }
            if (string.IsNullOrWhiteSpace(FioFather) || !Regex.IsMatch(FioFather, @"^[а-яА-ЯёЁ]{2,}(?:\s+[а-яА-ЯёЁ]{2,}){1,2}$"))
            {
                MessageBox.Show("Введите корректное ФИО отца");
                return;
            }
            if (string.IsNullOrWhiteSpace(DateBirthFather) || !Regex.IsMatch(DateBirthFather, @"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.\d{4}$"))
            {
                MessageBox.Show("Введите корректную дату рождения отца");
                return;
            }
            if (string.IsNullOrWhiteSpace(PlaceWorkFather) || !Regex.IsMatch(PlaceWorkFather, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректное место работы отца");
                return;
            }
            if (string.IsNullOrWhiteSpace(JobTitleFather) || !Regex.IsMatch(JobTitleFather, @"^[а-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("Введите корректную должность отца");
                return;
            }
            if (string.IsNullOrWhiteSpace(PlaceLifeFather) || !Regex.IsMatch(PlaceLifeFather, @"^[а-яА-ЯёЁ0-9\s\,\-\#№\.]+$"))
            {
                MessageBox.Show("Введите корректное место жительства отца");
                return;
            }
            if (!string.IsNullOrWhiteSpace(HomePhoneFather) && !Regex.IsMatch(HomePhoneFather, @"^((7|8)\d{10}|\d{10})$"))
            {
                MessageBox.Show("Введите корректный домашний номер отца");
                return;
            }
            if (!string.IsNullOrWhiteSpace(MobilePhoneFather) && !Regex.IsMatch(MobilePhoneFather, @"^((7|8)\d{10}|\d{10})$"))
            {
                MessageBox.Show("Введите корректный мобильный номер отца");
                return;
            }
        }
    }
}
