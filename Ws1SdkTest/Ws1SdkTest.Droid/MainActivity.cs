using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Airwatch.Login;

namespace Ws1SdkTest.Droid
{
    [Activity(Label = "Ws1SdkTest", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, SDKGatewayActivityDelegate.ICallback
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            
            Exception workspaceOneException = null;

            try
            {
                WorkspaceOne.Android.WorkspaceOne.Instance.Init(this);
                WorkspaceOne.Android.WorkspaceOne.Instance.OnCreate(savedInstanceState);

            

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"{this.GetType()} {e}");
                workspaceOneException = e;
            }

            var app = new App();
            LoadApplication(app);
            
            if (workspaceOneException != null)
            {
                app.MainPage.DisplayAlert($"Error: {workspaceOneException.GetType()}", workspaceOneException.Message, "Ok");
            }
            
            
        }

        public void OnTimeOut(SDKBaseActivityDelegate p0)
        {
            System.Diagnostics.Debug.WriteLine($"{this.GetType()}  OnTimeOut(SDKBaseActivityDelegate)");
            App.Current.MainPage.DisplayAlert($"Error: {p0.GetType()}", "OnTimeOut", "Ok");
        }
        
        protected override void OnResume()
        {
            System.Diagnostics.Debug.WriteLine($"{this.GetType()}  OnResume())");
            base.OnResume();
            WorkspaceOne.Android.WorkspaceOne.Instance.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
            WorkspaceOne.Android.WorkspaceOne.Instance.OnPause();
        }

        protected override void OnStart()
        {
            base.OnStart();
            WorkspaceOne.Android.WorkspaceOne.Instance.OnStart();
        }

        protected override void OnStop()
        {
            base.OnStop();
            WorkspaceOne.Android.WorkspaceOne.Instance.OnStop();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            WorkspaceOne.Android.WorkspaceOne.Instance.OnDestroy();
        }
        public override void OnUserInteraction()
        {
            base.OnUserInteraction();
            WorkspaceOne.Android.WorkspaceOne.Instance.OnUserInteraction();
        }

        public override bool DispatchKeyEvent(KeyEvent e)
        {
            WorkspaceOne.Android.WorkspaceOne.Instance.DispatchKeyEvent(e);
            return base.DispatchKeyEvent(e);
        }

        public override bool DispatchKeyShortcutEvent(KeyEvent e)
        {
            WorkspaceOne.Android.WorkspaceOne.Instance.DispatchKeyShortcutEvent(e);
            return base.DispatchKeyShortcutEvent(e);
        }

        public override bool DispatchTouchEvent(MotionEvent ev)
        {
            WorkspaceOne.Android.WorkspaceOne.Instance.DispatchTouchEvent(ev);
            return base.DispatchTouchEvent(ev);
        }

        public override bool DispatchTrackballEvent(MotionEvent ev)
        {
            WorkspaceOne.Android.WorkspaceOne.Instance.DispatchTrackballEvent(ev);
            return base.DispatchTrackballEvent(ev);
        }
        
    }
}