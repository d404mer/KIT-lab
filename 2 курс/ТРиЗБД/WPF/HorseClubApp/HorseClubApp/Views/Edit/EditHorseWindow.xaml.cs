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

namespace HorseClubApp.Views.Edit
{
    /// <summary>
    /// Interaction logic for EditHorseWindow.xaml
    /// </summary>
    public partial class EditHorseWindow : Window
    {
       private HORSE _currHorse = new HORSE();
        List<BREED> breedsList;
        List<USER> usersList;
        List<string> items = new List<string> { "Женский", "Мужской" };
        public EditHorseWindow(HORSE selectedHorse)
        {


           
            InitializeComponent();

            using (var context = new HorseClubDbEntities())
            {
                breedsList = context.BREEDs.ToList();
            }

            var comboBoxItems = breedsList.ToDictionary(type => type.BREED_ID, type => type.BREED_name).ToList();
            HorseComboBox.DisplayMemberPath = "BREED_name";
            HorseComboBox.SelectedValuePath = "BREED_ID";
            HorseComboBox.ItemsSource = breedsList;

            using (var context = new HorseClubDbEntities())
            {
                usersList = context.USERs.ToList();
            }

            var comboBox1Items = usersList.ToDictionary(type => type.USER_ID, type => type.USER_name).ToList();
            UserComboBox.DisplayMemberPath = "USER_name";
            UserComboBox.SelectedValuePath = "USER_ID";
            UserComboBox.ItemsSource = usersList;

            if (selectedHorse == null) return;
            _currHorse = selectedHorse;
            DataContext = _currHorse;
            Status.ItemsSource = items;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = false;
            if (Status.SelectedIndex != null && UserComboBox.SelectedIndex != null && HorseComboBox.SelectedIndex != null && HorseComboBox.SelectedItem != null && UserComboBox.SelectedItem != null)
            {
                flag = true;

                BREED selectedBreed = (BREED)HorseComboBox.SelectedItem;
                int BreedID = selectedBreed.BREED_ID;

                USER selectedUser = (USER)UserComboBox.SelectedItem;
                int UserId = selectedUser.USER_ID;
                _currHorse.FK_HORSE_breedID = BreedID;
                _currHorse.FK_USER_ID_HORSE = UserId;
            }

            foreach (var child in sp1.Children)
            {
                if (child is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        flag = false;
                        break; // Exit the loop early if one text box is empty
                    }
                }
            }

            if (flag)
            {
                string selectedValue = Status.SelectedItem.ToString();

                // Изменяем переменную status в зависимости от выбранного значения
                if (selectedValue == "Женский")
                {
                    _currHorse.HORSE_sex = false;
                }
                else
                {
                    _currHorse.HORSE_sex = true;
                }

                ;

                HorseClubDbEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись изменена");
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте заполнение всех полей");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true; // Отменить ввод символа, если он не является цифрой
                    return;
                }
            }
        }
    }
}
