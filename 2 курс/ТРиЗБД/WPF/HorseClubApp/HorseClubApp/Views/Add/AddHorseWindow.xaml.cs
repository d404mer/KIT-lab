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

namespace HorseClubApp.Views.Add
{
    /// <summary>
    /// Interaction logic for AddHorseWindow.xaml
    /// </summary>
    public partial class AddHorseWindow : Window
    {
        HORSE _currHorse = new HORSE();

        List<string> items = new List<string> { "Женский", "Мужской" };
        List<BREED> breedsList;
        List<USER> usersList;
        public AddHorseWindow()
        {
            InitializeComponent();
            Status.ItemsSource = items;
            


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

            DataContext = _currHorse;
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


                HorseClubDbEntities.GetContext().HORSEs.Add(_currHorse);
                HorseClubDbEntities.GetContext().SaveChanges();
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
