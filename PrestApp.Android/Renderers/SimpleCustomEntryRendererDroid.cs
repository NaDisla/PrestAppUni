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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PrestApp.Customs;
using PrestApp.Droid.Renderers;
using Android.Graphics.Drawables;

// LÓGICA DE ENSAMBLADO DE UN CUSTOM RENDERER
[assembly: ExportRenderer(typeof(SimpleCustomEntry), typeof(SimpleCustomEntryRendererDroid))]
namespace PrestApp.Droid.Renderers
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class SimpleCustomEntryRendererDroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(30f);
                gradientDrawable.SetStroke(6, Android.Graphics.Color.Rgb(5, 42, 72));
                gradientDrawable.SetColor(Android.Graphics.Color.Argb(255, 255, 255, 255));
                //gradientDrawable.SetSize(240, 49);
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(25, Control.PaddingTop, Control.PaddingRight,
                    Control.PaddingBottom);
            }
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}