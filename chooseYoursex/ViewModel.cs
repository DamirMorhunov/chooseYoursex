using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chooseYoursex
{
    class ViewModel : VMBase
    {
        private double _firstSliderValue;
        private double 
        public double Value { get => _firstSliderValue; set { _firstSliderValue = value; OnPropertyChanged(nameof(Value)); } }

    }
}
