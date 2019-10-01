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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label a =new Label();
            B _tempB = new B(a);
            _tempB.DoiTextLabel("Understand");
        }
    }

    public class B
    {
        Label _label = new Label();
        MainWindow _tempMain; 
        public B(Label _main)
        {
            _label = _main;
        }
        public void DoiTextLabel(string str)
        {
         _label.Content = str;

        }
    }
}
