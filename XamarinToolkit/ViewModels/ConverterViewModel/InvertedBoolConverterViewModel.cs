using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class InvertedBoolConverterViewModel : BaseViewModel
    {
        public InvertedBoolConverterViewModel()
        {
            Title = "Inverted Bool Converter";
            MyBooleanValue = true;
        }
        private bool _MyBooleanValue;
        public bool MyBooleanValue
        {
            get => _MyBooleanValue;
            set => SetProperty(ref _MyBooleanValue, value);
        }
    }
}
