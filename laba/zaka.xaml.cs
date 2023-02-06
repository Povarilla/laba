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

namespace laba
{
    /// <summary>
    /// Логика взаимодействия для zaka.xaml
    /// </summary>
    public partial class zaka : Window
    {
        djopaEntities context;
        Class2 Class2;
        public zaka()
        {
            InitializeComponent();
            context = new djopaEntities();
            Class2 = new Class2();
            grid2.ItemsSource = context.Заказчик.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Dob111 = new Заказчик();
            context.Заказчик.Add(Dob111);
            var Dob122 = new dobr3(context, Dob111);
            Dob122.ShowDialog();
            Update();
        }
        private void Update()
        {
            grid2.ItemsSource = context.Заказчик.ToList();
            grid2.Items.Refresh();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var NewMainWindow = new MainWindow();
            NewMainWindow.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var Newpiza = new piza();
            Newpiza.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var Newpizail = new pizail();
            Newpizail.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var Newrazr = new razr();
            Newrazr.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var genPiza = Class2.Generate();
            context.Заказчик.Add(genPiza);
            var Dob12222 = new dobr3(context, genPiza);
            Dob12222.ShowDialog();
            Update();
        }
    }
}
