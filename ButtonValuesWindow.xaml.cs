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

namespace WpfApp2
{
    /// <summary>
   
   
    public partial class ButtonValuesWindow : Window
    {

       
        public ButtonValuesWindow( string width, string height, string text)
        {
            InitializeComponent();

            WidthText.Text = width;
            HeightText.Text = height;
            this.TextShow.Text = text;

        }
        public ButtonValuesWindow()
        {


        }
    }
}
