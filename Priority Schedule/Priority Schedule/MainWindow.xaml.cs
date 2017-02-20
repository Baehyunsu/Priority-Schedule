using System;
using System.Collections.Generic;
using System.Data;
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

namespace Priority_Schedule
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private data d;
        private TextBox t;
        public MainWindow()
        {
            InitializeComponent();
            
            //d = new data { work = "wake up" };
            //this.DataContext = d;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBox.Text + " 추가.");
            //d = new Priority_Schedule.data { work = textBox.Text };
            //this.DataContext = d;

            t = new TextBox(); //make textbox
            t.Text = textBox.Text; //text of textbox is textbox.text
            stackpanel.Children.Add(t); //add new textbox to stackpanel
        }

        //delete button
    }
}
