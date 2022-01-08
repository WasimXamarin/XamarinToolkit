using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class NotEqualConverterViewModel : BaseViewModel
    {
        public NotEqualConverterViewModel()
        {
            Title = "Not Equal Converter";
            MyFirstObject = "value";
        }

        private string _MyFirstObject;
        public string MyFirstObject
        {
            get => _MyFirstObject;
            set => SetProperty(ref _MyFirstObject, value);
        }
    }
}
