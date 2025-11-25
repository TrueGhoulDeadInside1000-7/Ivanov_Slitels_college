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

namespace Ivanov_Slitels_college.View.Page
{
    /// <summary>
    /// Логика взаимодействия для AddActivityPage1.xaml
    /// </summary>
    public partial class AddActivityPage1 : Page
    {
        public AddActivityPage1()
        {
            InitializeComponent();

            DirectionCmb.SelectedValuePath = "Id";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void Add1Tb_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ActivityTb.Text) && string.IsNullOrEmpty(DirectionCmb.Text))
                MessageBox.Show("Заполните все поля", "Ошибка чтения данных", MessageBoxButton.OK, MessageBoxImage.Error);

            else
            {
                Activity activity = new Activity()
                {
                    Name = ActivityTb.Text,
                    Direction = DirectionCmb.SelectedItem as Direction
                };

                App.context.Activity.Add(activity);
                App.context.SaveChanges();
                MessageBox.Show("Активность добавлена");
            }
        }
    }
}