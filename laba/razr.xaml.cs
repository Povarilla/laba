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
    /// Логика взаимодействия для razr.xaml
    /// </summary>
    public partial class razr : Window
    {
        djopaEntities context;
        RazrSeeder razrSeeder;

        public razr()
        {
            InitializeComponent();
            razrSeeder = new RazrSeeder();
            context = new djopaEntities();
            grid5.ItemsSource = context.Разряд.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Dob11111 = new Разряд();
            context.Разряд.Add(Dob11111);
            var Dob12222 = new dobr5(context, Dob11111);
            Dob12222.ShowDialog();
            Update();
        }
        private void Update()
        {
            grid5.ItemsSource = context.Разряд.ToList();
            grid5.Items.Refresh();

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
            var Newzaka = new zaka();
            Newzaka.Show();
            Close();
        }


       
                private void Button_Click_6(object sender, RoutedEventArgs e)
                {
            var genRazr = razrSeeder.Generate();
             context.Разряд.Add(genRazr);
             var Dob12222 = new dobr5(context, genRazr);
                Dob12222.ShowDialog();
                Update();
        }
            }
        
    }

