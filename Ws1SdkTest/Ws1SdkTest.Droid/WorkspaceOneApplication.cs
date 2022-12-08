using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using WorkspaceOne.Android;

namespace Ws1SdkTest.Droid
{
    [Application]
    public class Application : WorkspaceOneApplication
    {
        public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            global::Android.Util.Log.Debug(this.GetType().ToString(), "ctor(IntPtr, JniHandleOwnership)");
        }

        public override Intent MainActivityIntent
        {
            get
            {
                return new Intent(AwAppContext, typeof(MainActivity));
            }
        }

        public override void OnCreate()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"{this.GetType()} OnCreate()");
                base.OnCreate(this);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
         
        }

     
    }
}