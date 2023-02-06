using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для piza.xaml
    /// </summary>
    public partial class piza : Window
    {
        djopaEntities context;
        Class1 Class1;
        public piza()
        {
            InitializeComponent();
            context = new djopaEntities();
            Class1 = new Class1();
            grid1.ItemsSource = context.Пицца.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Dob11 = new Пицца();
            context.Пицца.Add(Dob11);
            var Dob12 = new dobr1(context, Dob11);
            Dob12.ShowDialog();
            Update();
        }
        private void Update()
        {
            grid1.ItemsSource = context.Пицца.ToList();
            grid1.Items.Refresh();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var NewMainWindow = new MainWindow();
            NewMainWindow.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var Newzaka = new zaka();
            Newzaka.Show();
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

        private void p_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (p.Text == null)
            {
                return;
            }
            List<Пицца> azx = context.Пицца.ToList();
            azx = azx.Where(x => x.Пицца1.ToLower().Contains(p.Text.ToLower())).ToList();
            grid1.ItemsSource = azx.OrderBy(x => x.ID).ToList();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var genPiza = Class1.Generate();
            context.Пицца.Add(genPiza);
            var Dob12222 = new dobr1(context, genPiza);
            Dob12222.ShowDialog();
            Update();

        }
    }
}
