using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WorkspaceOne.Forms;
using WorkspaceOne.Forms.Interfaces;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Ws1SdkTest
{
    public partial class App : Application, IAWSDKDelegate
    {
        public App()
        {
            InitializeComponent();

            var ws = DependencyService.Get<IWorkspaceOne>();
            ws.FormsDelegate = this;
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void InitialCheckFinished(bool error)
        {
            throw new NotImplementedException();
        }

        public void ProfilesReceived(AWProfile[] profiles)
        {
            throw new NotImplementedException();
        }

        public void ApplicationProfileReceived(AWApplicationProfile profile)
        {
            throw new NotImplementedException();
        }

        public void Wipe()
        {
            throw new NotImplementedException();
        }

        public void Lock()
        {
            throw new NotImplementedException();
        }

        public void Unlock()
        {
            throw new NotImplementedException();
        }

        public void StopNetworkActivity(AWNetworkActivityStatus status)
        {
            throw new NotImplementedException();
        }

        public void ResumeNetworkActivity()
        {
            throw new NotImplementedException();
        }

        public void UserChanged()
        {
            throw new NotImplementedException();
        }

        public void EnrollmentStatusReceived(object status)
        {
            throw new NotImplementedException();
        }

        public void OnHandleWork()
        {
            throw new NotImplementedException();
        }

        public void OnAnchorAppUpgrade()
        {
            throw new NotImplementedException();
        }

        public void OnAnchorAppStatusReceived()
        {
            throw new NotImplementedException();
        }

        public void OnApplicationConfigurationChange()
        {
            throw new NotImplementedException();
        }
    }
}