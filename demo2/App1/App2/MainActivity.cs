using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Andrognito.Patternlockview;
using Com.Andrognito.Patternlockview.Utils;

namespace App2
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            RequestWindowFeature(Android.Views.WindowFeatures.NoTitle);
           
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
      
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Window.SetFlags(Android.Views.WindowManagerFlags.Fullscreen, Android.Views.WindowManagerFlags.Fullscreen);
 
            var mPatternLockView = (PatternLockView)FindViewById(Resource.Id.patter_lock_view);
            mPatternLockView.DotCount = 3;
            mPatternLockView.DotNormalSize = (int)ResourceUtils.GetDimensionInPx(this, Resource.Dimension.pattern_lock_dot_size);
            mPatternLockView.DotSelectedSize = (int)ResourceUtils.GetDimensionInPx(this, Resource.Dimension.pattern_lock_dot_selected_size);
            mPatternLockView.PathWidth = (int)ResourceUtils.GetDimensionInPx(this, Resource.Dimension.pattern_lock_path_width);
            mPatternLockView.AspectRatioEnabled = true;
            mPatternLockView.SetAspectRatio(PatternLockView.AspectRatio.AspectRatioWidthBias);
            mPatternLockView.SetViewMode(PatternLockView.PatternViewMode.Correct);
            mPatternLockView.DotAnimationDuration = 150;
            mPatternLockView.PathEndAnimationDuration = 100;
            mPatternLockView.CorrectStateColor = ResourceUtils.GetColor(this, Resource.Color.white);
            mPatternLockView.InStealthMode = false;
            mPatternLockView.TactileFeedbackEnabled = true;
            mPatternLockView.InputEnabled = true;

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}