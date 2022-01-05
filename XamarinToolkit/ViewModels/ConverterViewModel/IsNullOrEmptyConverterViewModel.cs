using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class IsNullOrEmptyConverterViewModel : BaseViewModel
    {
        public IsNullOrEmptyConverterViewModel()
        {
            Title = "Is Null Or Empty Converter";
            MyStringValue = null;
        }

        private string _MyStringValue;
        public string MyStringValue
        {
            get => _MyStringValue;
            set => SetProperty(ref _MyStringValue, value);
        }
    }
}
