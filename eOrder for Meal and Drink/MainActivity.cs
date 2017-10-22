using Android.App;
using Android.Widget;
using Android.OS;

namespace eOrder_for_Meal_and_Drink
{
    [Activity(Label = "eOrder_for_Meal_and_Drink", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

