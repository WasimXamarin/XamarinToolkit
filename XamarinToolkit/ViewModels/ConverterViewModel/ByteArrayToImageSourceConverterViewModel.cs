using System;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class ByteArrayToImageSourceConverterViewModel : BaseViewModel
    {
        public ICommand PageAppearingCommand { get; }

        public ByteArrayToImageSourceConverterViewModel()
        {
            Title = "Byte Array To Image Source Converter";
            PageAppearingCommand = CommandFactory.Create(OnAppearing);
        }

        private async Task OnAppearing()
        {
            try
            {
                IsBusy = true;

                using var client = new HttpClient();
                var response = await client.GetAsync("https://www.google.com/search?q=salman+khan&source=lnms&tbm=isch&sa=X&ved=2ahUKEwj909-Xi5H1AhUwQPUHHbtHBDoQ_AUoAnoECAEQBA&biw=2029&bih=990&dpr=2#imgrc=yEGHmtwFVUjHlM");
                var byteData = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);

                Avatar = byteData;

                Profile = ImageSource.FromStream(() => new MemoryStream(Avatar));

            }
            catch (Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

        private byte[]? _Avatar;
        public byte[]? Avatar
        {
            get { return _Avatar; }
            set { SetProperty(ref _Avatar, value); }
        }

        private ImageSource _Profile;
        public ImageSource Profile
        {
            get { return _Profile; }
            set { SetProperty(ref _Profile, value); }
        }
    }
}
