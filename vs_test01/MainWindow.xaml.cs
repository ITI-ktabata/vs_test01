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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            object hoge = ConfigurationManager.AppSettings["oraattusrc01"];
            ConnectionStringSettingsCollection hoge2 = ConfigurationManager.ConnectionStrings;

            // バインディング対象のインスタンスを、MainWindowViewModelに設定
            this.DataContext = new MainWindowViewModel();
            label01.Content = OracleDao.hogehoge();
            //listBox01.
        }

        private async void button01_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => label02.Content = OracleDao.hogehoge2());
            //label02.Content = textBox01.Text;
            
        }
        
    }
    // MainWindowクラスから完全に独立したクラス（ビューモデル）
    public sealed class MainWindowViewModel
    {
        // バインディングされる値を保持するフィールド
        private string sampleText_ = "Bound!";

        // バインディング対象のプロパティ
        public string SampleText
        {
            get
            {
                return sampleText_;
            }
            set
            {
                sampleText_ = value;
            }
        }
    }
}
