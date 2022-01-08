using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class MultiConverterViewModel : BaseViewModel
    {
        public MultiConverterViewModel()
        {
            Title = "Multi Converter";
        }

        string enteredName = "Steven";

        public string EnteredName
        {
            get => enteredName;
            set => SetProperty(ref enteredName, value);
        }
    }
}
