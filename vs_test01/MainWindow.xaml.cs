using System;
using System.Configuration;
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

namespace vs_test01
{
    using vs_test01.ViewModels;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            // バインディング対象のインスタンスを、MainWindowViewModelに設定
            //this.DataContext = new MainWindowViewModel();
            //this.DataContext = new MainViewModel();
            this.listBox01.SelectedIndex = -1;
            this.listBox02.SelectedIndex = -1;
            this.listBox03.SelectedIndex = -1;
            this.listBox04.SelectedIndex = -1;
            this.listBox05.SelectedIndex = -1;
        }

        private async void button01_Click(object sender, RoutedEventArgs e)
        {
            //await Task.Run(() => label02.Content = OracleDao.hogehoge2());
            //label02.Content = textBox01.Text;
            
        }
    }
}
