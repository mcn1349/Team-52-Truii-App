﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Renderscripts;
using UK.CO.Chrisjenx.Calligraphy;
using Truii_App.Functions;

namespace Truii_App
{
    [Activity(Label = "LoginActivity", Theme = "@android:style/Theme.NoTitleBar.Fullscreen")]
    public class LoginActivity : Activity
    {
        TextView txtUsername;
        TextView txtPassword;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);
            txtUsername = FindViewById<TextView>(Resource.Id.txtUser);
            txtPassword = FindViewById<TextView>(Resource.Id.txtPassword);
            var btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += BtnLogin_Click;
            // Create your application here
            FontFunction font = new FontFunction();
            font.CreateFont("Oswald-Regular");
            font.CreateFont("Arberkley");
        }
        protected override void AttachBaseContext(Context @base)
        {
            base.AttachBaseContext( CalligraphyContextWrapper.Wrap(@base));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}