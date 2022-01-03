using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class DoubleToIntConverterViewModel : BaseViewModel
    {
        public DoubleToIntConverterViewModel()
        {
            Title = "Double ToInt Converter";
            MyDouble = 3.25;
        }

        private double _MyDouble;
        public double MyDouble
        {
            get => _MyDouble;
            set => SetProperty(ref _MyDouble, value);
        }
    }
}
