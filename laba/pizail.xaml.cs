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
    /// Логика взаимодействия для pizail.xaml
    /// </summary>
    public partial class pizail : Window
    {
        djopaEntities context;
        Class3 Class3;
        public pizail()
        {
            InitializeComponent();
            context = new djopaEntities();
            Class3= new Class3();   
            grid4.ItemsSource = context.Пиццайоло.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Dob1111 = new Пиццайоло();
            context.Пиццайоло.Add(Dob1111);
            var Dob1222 = new dobr4(context, Dob1111);
            Dob1222.ShowDialog();
            Update();
        }
        private void Update()
        {
            grid4.ItemsSource = context.Пиццайоло.ToList();
            grid4.Items.Refresh();

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
            var Newzaka = new zaka();
            Newzaka.Show();
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
            var genPiza = Class3.Generate();
            context.Пиццайоло.Add(genPiza);
            var Dob12222 = new dobr4(context, genPiza);
            Dob12222.ShowDialog();
            Update();
        }
    }
}
