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
        private double _slider1MaxValue = 100;
        private double _slider2MaxValue = 100;
        private double _firstSliderValue;
        private double _secondSliderValue = 100;
        public double FirstSliderValue { get => _firstSliderValue; set { _firstSliderValue = value; OnPropertyChanged(nameof(FirstSliderValue)); } }
        public double SecondSliderValue { get => _secondSliderValue; set { _secondSliderValue = value; OnPropertyChanged(nameof(SecondSliderValue)); } }
        public double Slider1MaxValue { get => _secondSliderValue; set { _secondSliderValue = value; OnPropertyChanged(nameof(Slider1MaxValue)); } }
        public double Slider2MaxValue { get => _secondSliderValue; set { _secondSliderValue = value; OnPropertyChanged(nameof(Slider2MaxValue)); } }

        private void FirstSliderValueChanged(object o)
        {
            _secondSliderValue = _slider1MaxValue - _secondSliderValue;
        }
        private void SecondSliderValueChanged(object o)
        {
            _firstSliderValue = _slider2MaxValue - _firstSliderValue;
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
