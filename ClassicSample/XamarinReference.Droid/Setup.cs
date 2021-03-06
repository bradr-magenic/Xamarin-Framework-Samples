using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using XamarinReference.Lib.Interface;
using XamarinReference.Droid.Services;
using XamarinReference.Lib.Services;
using XamarinReference.Droid.Network;

namespace XamarinReference.Droid
{
    public static class Setup
    {
		public static void Initialize(Context applicationContext)
        {
            MvxSimpleIoCContainer.Initialize();

            Mvx.LazyConstructAndRegisterSingleton<INavigationMenuService<Fragment>, NavigationMenuService>();
            Mvx.RegisterSingleton(typeof(IStringLookupService), new StringLookupService(applicationContext));
			Mvx.RegisterSingleton(typeof(IVersionInfo), new VersionInfoService(applicationContext));
			Mvx.LazyConstructAndRegisterSingleton<ILoggingService, FileLoggingService>();
			Mvx.LazyConstructAndRegisterSingleton<IFileHelper, FileHelper>();
			Mvx.LazyConstructAndRegisterSingleton<IJobsService, JobsService>();
			Mvx.LazyConstructAndRegisterSingleton<IITunesDataService, ITunesDataService>();
			Mvx.LazyConstructAndRegisterSingleton<ICreateHttpClientHelper, AndroidConnectionHandlerCreator>();
        }  
    }
}
