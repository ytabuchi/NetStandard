# Sample for .NET Standard

This is a sample solution for .NET Standard and Xamarin.Forms

Notice: 

1. It uses [Translator Text API](https://azure.microsoft.com/ja-jp/services/cognitive-services/translator-text-api/) of Microsoft cognitive services.
1. You need create Translator Text API on your Azure account. (Free version is provided.)

Infomation:

- WPF project has api call within it.
- I created .NET Standard 1.4 library project and copy files from WPF project. Also I build NuGet package.
- I created .NET Core console project that references .NET Standard library project.
- I created Xamarin.Forms project and change from PCL to .NET Standard and use my NuGet package. 

