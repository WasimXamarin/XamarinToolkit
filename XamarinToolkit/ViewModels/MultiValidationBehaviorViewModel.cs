using System;

using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.IO;
using Plugin.Media;

namespace XamarinToolkit.ViewModels
{
    public class MultiValidationBehaviorViewModel : BaseViewModel
    {
        public MultiValidationBehaviorViewModel()
        {
            Title = "Multi Validation Behavior";
        }


        private string _PhotoPath;
        public string PhotoPath
        {
            get { return _PhotoPath; }
            set { SetProperty(ref _PhotoPath, value); }
        }

        private ImageSource _ImageSet;
        public ImageSource ImageSet
        {
            get { return _ImageSet; }
            set { SetProperty(ref _ImageSet, value); }
        }

        public Command ImageCommand
        {
            get { return new Command(OnImageClicked); }
        }

        private void OnImageClicked(object obj)
        {
            _ = TakePhotoAsync(); // Display the Image Path
        }

        async Task TakePhotoAsync()
        {
            try
            {
                var permission = await Permissions.CheckStatusAsync<Permissions.Camera>();
                if (permission != PermissionStatus.Granted)
                {
                    permission = await Permissions.RequestAsync<Permissions.Camera>();
                }
                if (permission == PermissionStatus.Denied)
                {
                    return;
                }
                if (permission == PermissionStatus.Granted)
                {
                    var PhotoData = await MediaPicker.CapturePhotoAsync();
                    var StoragePermission = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
                    if(StoragePermission != PermissionStatus.Granted)
                    {
                        StoragePermission = await Permissions.RequestAsync<Permissions.StorageWrite>();
                    }
                    if(StoragePermission == PermissionStatus.Denied)
                    {
                        return;
                    }
                    if(StoragePermission == PermissionStatus.Granted)
                    {
                        await LoadPhotoAsync(PhotoData);
                    }
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {fnsEx.Message}");
            }
            catch (PermissionException pEx)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {pEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photoData)
        {
            // canceled
            if (photoData == null)
            {
                PhotoPath = null;
                return;
            }

            var streamValue = await photoData.OpenReadAsync();
            ImageSet = ImageSource.FromStream(() => streamValue);

            //// save the file into local storage File Path Display on the Label
            //var newFile = Path.Combine(FileSystem.CacheDirectory, photoData.FileName);
            //using (var stream = await photoData.OpenReadAsync())
            //{
            //    using (var newStream = File.OpenWrite(newFile))
            //    {
            //        await stream.CopyToAsync(newStream);
            //    }
            //}
            //PhotoPath = newFile;
        }


    }
}
