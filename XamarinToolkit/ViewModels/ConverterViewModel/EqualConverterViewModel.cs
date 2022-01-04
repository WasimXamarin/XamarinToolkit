using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class EqualConverterViewModel : BaseViewModel
    {
        public EqualConverterViewModel()
        {
            Title = "Equal Converter";
            MyFirstObject = false;
        }

        private bool _MyFirstObject;
        public bool MyFirstObject
        {
            get => _MyFirstObject;
            set => SetProperty(ref _MyFirstObject, value);
        }
    }
}
