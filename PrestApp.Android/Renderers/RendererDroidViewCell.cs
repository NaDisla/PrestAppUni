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
using View = Android.Views.View;
using PrestApp.Customs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCell))]
namespace PrestApp.Droid.Renderers
{
    public class RendererDroidViewCell :  ViewCellRenderer
    {
        protected override View GetCellCore(Cell item, View convertView, ViewGroup parent, Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context);
            var listView = parent as Android.Widget.ListView;

            if (listView != null)
            {
                // Disable native cell selection color style - set as *Transparent*
                listView.SetSelector(Android.Resource.Color.DarkerGray);
                listView.CacheColorHint = Android.Graphics.Color.DarkGray;
            }

            return cell;
        }
    }
}