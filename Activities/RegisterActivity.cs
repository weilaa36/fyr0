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

namespace FYRAPP.Activities
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText txtCreateUsername;
        EditText txtEmailAddress;
        EditText txtCreatePassword;
        EditText txtReenterPassword;
        Button btnCreateAccount; 
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            txtCreateUsername = FindViewById<EditText>(Resource.Id.txtCreateUsername);
            txtEmailAddress = FindViewById<EditText>(Resource.Id.txtEmailAddress);
            txtCreatePassword = FindViewById<EditText>(Resource.Id.txtCreatePassword);
            txtReenterPassword = FindViewById<EditText>(Resource.Id.txtReenterPassword);
            btnCreateAccount = FindViewById<Button>(Resource.Id.btnCreateAccount);

           btnCreateAccount.Click += BtnCreateAccount_Click;
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(HomepageActivity));
        }
    }
}