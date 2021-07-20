using SQLite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.IO;

namespace HangmanGame
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Android.Widget.EditText txt; 
        Android.Widget.EditText txtpwd;
        Android.Widget.Button btn;

        // declartion of variables

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            txt = FindViewById<EditText>(Resource.Id.edtUser);
            txtpwd = FindViewById<EditText>(Resource.Id.edtpssword);

            btn = FindViewById<Button>(Resource.Id.btnLogin);
            btn.Click += new EventHandler(Btntest_Clicked);
        }

        // login testing the right creadialtions 

        private void Btntest_Clicked(object sender, EventArgs e)
        {
            String usr = txt.Text.ToString();
            String pwd = txtpwd.Text.ToString();
            if (usr.Equals("admin@gmail.com") && pwd.Equals("123456"))
            {
                Intent intent = new Intent(this, typeof(home));
                StartActivity(intent);
            }
            else
            {
            Toast.MakeText(Application.Context, "Invalid Login / Username", ToastLength.Short).Show();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}