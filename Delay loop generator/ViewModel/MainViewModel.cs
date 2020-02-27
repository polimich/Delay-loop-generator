using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Media.Imaging;

namespace Delay_loop_generator.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        #region Binding
        private string _register1;
        private string _register2;
        private string _register3;
        private int? _cycles;
        private bool _radioButton1;
        private bool _radioButton2;
        private string _rate;
        private int? _time;
        private string _program;
        public string Register1 { get => _register1; set { _register1 = value; NotifyPropertyChanged(); } }
        public string Register2 { get => _register2; set { _register2 = value; NotifyPropertyChanged(); } }
        public string Register3 { get => _register3; set { _register3 = value; NotifyPropertyChanged(); } }
        public bool RadioButton1 { get => _radioButton1; set { _radioButton1 = value; NotifyPropertyChanged(); } }
        public bool RadioButton2 { get => _radioButton2; set { _radioButton2 = value; NotifyPropertyChanged(); } }
        public int? Cycles { get => _cycles; set { _cycles = value; NotifyPropertyChanged(); } }
        public string Rate { get => _rate; set { _rate = value; NotifyPropertyChanged(); } }
        public int? Time { get => _time; set { _time = value; NotifyPropertyChanged(); } }
        public string Program { get => _program; set { _program = value; NotifyPropertyChanged(); } }
        public List<string> DropdownR { get; set; }
        public List<string> DropdownCycle { get; set; }

        #endregion
        public MainViewModel()
        {
            _register1 = "R3";
            _register2 = "R4";
            _register3 = "R5";
            _radioButton1 = true;
            _program = "New Program";
            _cycles = 16777215;
            _rate = "4.0000";
            DropdownR = new List<string> { "R0", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "R11", "R12" };
            DropdownCycle = new List<string> { "1,0000", "1,8432", "2,0000", "2,4576", "3,2768", "3,6864", "4,0000", "4,6080", "7,3728", "8,0000", "9,1260", "11,059" };
            //Copy = new RelayCommand(
            //    () => { Clipboard.SetContent(_program); },
            //    () => true);
        }

        public RelayCommand CommandCZ { get; set; }
        public RelayCommand CommandENG { get; set; }
        public RelayCommand Copy { get; set; }
        public RelayCommand Start { get; set; }

        #region Notify
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

    }
}
