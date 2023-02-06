using Microsoft.Win32;
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

namespace laba
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        djopaEntities context;
        Class4 Class4;
        public MainWindow()
        {
            InitializeComponent();
            context = new djopaEntities();
            Class4 = new Class4();
            grid.ItemsSource = context.Готовка_пиццы.ToList();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            var Dob = new Готовка_пиццы();
            context.Готовка_пиццы.Add(Dob);
            var Dob1 = new dobr(context, Dob);
            Dob1.ShowDialog();
            Update();
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            Button red1 = sender as Button;
            var red2 = red1.DataContext as Готовка_пиццы;
            var red3 = new dobr(context, red2);
            red3.ShowDialog();
            Update();

        }
        private void Update()
        {
            grid.ItemsSource = context.Готовка_пиццы.ToList();
            grid.Items.Refresh();

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var dea = grid.SelectedItem as Готовка_пиццы;
            if (dea == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            context.Готовка_пиццы.Remove(dea);
            context.SaveChanges();
            Update();

        }

        private void vih1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var NewWpiza = new piza();
            NewWpiza.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Newzaka = new zaka();
            Newzaka.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Newpizail = new pizail();
            Newpizail.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var Newrazr = new razr();
            Newrazr.Show();
            Close();
        }

       
        private void ShowTable()
        {
            grid.ItemsSource = context.Готовка_пиццы.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var genPiza = Class4.Generate();
            context.Готовка_пиццы.Add(genPiza);
            var Dob12222 = new dobr(context, genPiza);
            Dob12222.ShowDialog();
            Update();
        }
    }
}
