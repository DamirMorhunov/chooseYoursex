using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chooseYoursex
{
    class ViewModel : VMBase
    {
        private RelayCommand _firstSlidervalueChanged;
        private RelayCommand _secondSlidervalueChanged;
        private double _firstSliderValue;
        private double _secondSliderValue;
        public double FirstSliderValue { get => _firstSliderValue; set { _firstSliderValue = value; OnPropertyChanged(nameof(FirstSliderValue)); } }
        public double SecondSliderValue { get => _secondSliderValue; set { _secondSliderValue = value; OnPropertyChanged(nameof(SecondSliderValue)); } }
        private void FirstSliderValueChanged(object o)
        {
            _secondSliderValue = _firstSliderValue;
        }
        private void SecondSliderValueChanged(object o)
        {
            _firstSliderValue = _secondSliderValue;
        }
        public ViewModel()
        {
            _firstSlidervalueChanged = new RelayCommand(FirstSliderValueChanged);
            _secondSlidervalueChanged = new RelayCommand(SecondSliderValueChanged);
        }
        public ICommand FirstSliderValueChangedCommand;
        public ICommand SecondSliderValueChangedCommand;

    }
}
