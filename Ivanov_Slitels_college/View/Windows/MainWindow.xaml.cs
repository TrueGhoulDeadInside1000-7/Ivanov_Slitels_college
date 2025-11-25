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
using Ivanov_Slitels_college.View.Page;

namespace Ivanov_Slitels_college.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddGroupPage1());
        }

        private void AddActivity_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddActivityPage1());
        }

        private void Journal_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalPage1());
        }

        private void Report1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportPage1());
        }

        private void Report2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportPage2());
        }
    }
}
