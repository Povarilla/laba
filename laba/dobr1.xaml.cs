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
    /// Логика взаимодействия для dobr1.xaml
    /// </summary>
    public partial class dobr1 : Window
    {
        djopaEntities context;
        public dobr1(djopaEntities context,Пицца пицца)
        {
            InitializeComponent();
            this.context = context;
            this.DataContext = пицца;
        }

        private void vih_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void sohr_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            Close();
        }
    }
}
