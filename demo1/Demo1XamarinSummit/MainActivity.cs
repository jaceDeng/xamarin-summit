using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Demo1XamarinSummit
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //Com.Github.Gcacace.Signaturepad.Views.SignaturePad pad = new Com.Github.Gcacace.Signaturepad.Views.SignaturePad(this, null);
            //this.AddContentView(pad, new Android.Views.ViewGroup.LayoutParams(100,100));
            var pad = FindViewById<Com.Github.Gcacace.Signaturepad.Views.SignaturePad>(Resource.Id.signature_pad);
            pad.SetPenColor(Android.Graphics.Color.Red);

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}