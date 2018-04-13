using Android.App;
using Android.Widget;
using Android.OS;
using FYRAPP.Activities;

namespace FYRAPP
{
    [Activity(Label = "FYRAPP", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtUsername;
        EditText txtPassword;
        Button btnLogin;
        Button btnRegister;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);

            //Step 4: Making the buttons do something
            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(RegisterActivity));
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(HomepageActivity));

        }


    }
}

