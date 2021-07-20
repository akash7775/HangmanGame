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

namespace HangmanGame
{
    [Activity(Label = "home")]
    public class home : Activity
    {
        Android.Widget.Button p1Btn;
        Android.Widget.Button p2Btn;
        Android.Widget.Button wordBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.home);

            p1Btn = FindViewById<Button>(Resource.Id.btnOne);
            p1Btn.Click += new EventHandler(Btntest1_Clicked);
            wordBtn = FindViewById<Button>(Resource.Id.btnWords);
            wordBtn.Click += new EventHandler(Btntest3_Clicked);
        }

        // staring new activity 
        private void Btntest1_Clicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(tskGme));
            StartActivity(intent);
        }
        private void Btntest2_Clicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(tskGme));
            StartActivity(intent);
        }
        private void Btntest3_Clicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(wordManage));
            StartActivity(intent);
        }
    }
}
