using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class MainWindowViewModel
    {
        MainWindow _mw;
        public DelegateCommand MyDelegate { get; set; }


        public Double Height { get; set; }

        public Double Width { get; set; }

        public string TextValue { get; set; }





        public MainWindowViewModel(MainWindow mw)
        {
            _mw = mw; 
            MyDelegate = new DelegateCommand(ExecuteCommand, CanExecuteMethod);
            //ButtonValuesWindow bvw = new ButtonValuesWindow(Width, Height, TextValue);
           
        }

        private void ExecuteCommand()
        {
            ButtonValuesWindow vm = new ButtonValuesWindow(_mw.txtblk1.Text, _mw.txtblk2.Text, _mw.myTxt.Text);
            vm.Show();
        }

        private bool CanExecuteMethod()
        {
            return true;
        }
    }
}
