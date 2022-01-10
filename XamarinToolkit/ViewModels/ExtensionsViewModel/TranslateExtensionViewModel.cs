﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Essentials;
using XamarinToolkit.Models.ExtensionsModel;
using XamarinToolkit.Resx;

namespace XamarinToolkit.ViewModels.ExtensionsViewModel
{
    public class TranslateExtensionViewModel : BaseViewModel
    {
        IList<Language> supportedLanguages = Enumerable.Empty<Language>().ToList();

        Language selectedLanguage = new Language(AppResources.English, "en");

        public TranslateExtensionViewModel()
        {
            Title = "Translate Extension";

            ChangeLanguageCommand = CommandFactory.Create(() =>
            {
                LocalizationResourceManager.Current.CurrentCulture = CultureInfo.GetCultureInfo(SelectedLanguage.CI);
                LoadLanguages();
            });
        }

		public LocalizedString AppVersion { get; } = new LocalizedString(() => string.Format(AppResources.Version, AppInfo.VersionString));

		public ICommand ChangeLanguageCommand { get; }

		public Language SelectedLanguage
		{
			get => selectedLanguage;
			set => SetProperty(ref selectedLanguage, value);
		}

		public IList<Language> SupportedLanguages
		{
			get => supportedLanguages;
			private set => SetProperty(ref supportedLanguages, value);
		}

		void LoadLanguages()
		{
			SupportedLanguages = new List<Language>()
			{
				{ new Language(AppResources.English, "en") },
				{ new Language(AppResources.Spanish, "es") }
			};
			SelectedLanguage = SupportedLanguages.FirstOrDefault(pro => pro.CI == LocalizationResourceManager.Current.CurrentCulture.TwoLetterISOLanguageName);
		}
	}
}
