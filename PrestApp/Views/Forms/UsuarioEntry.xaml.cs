using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Forms
{
    /// <summary>
    /// View used to show the email entry with validation status.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioEntry" /> class.
        /// </summary>

        public UsuarioEntry()
        {
            InitializeComponent();
        }
    }
}