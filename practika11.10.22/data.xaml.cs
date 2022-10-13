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

namespace practika11._10._22
{
    /// <summary>
    /// Логика взаимодействия для data.xaml
    /// </summary>
    public partial class data : Window
    {
        public data()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddData addData = new AddData();
            addData.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            delete.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pechat pechat = new pechat();
            pechat.Show();
            this.Close();
        }
    }
}
