using System;



namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class DateTimeOffsetConverterViewModel : BaseViewModel
    {
        public DateTimeOffsetConverterViewModel()
        {
            Title = "Date Time Offset Converter";
        }

        private DateTimeOffset _TheDate;
        public DateTimeOffset TheDate
        {
            get => _TheDate;
            set => SetProperty(ref _TheDate, value);
        }
    }
}
