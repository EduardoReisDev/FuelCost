using Android.Content;
using FuelCost.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(NoOutlineEntryRenderer))]
namespace FuelCost.Droid.CustomRenderer
{
    public class NoOutlineEntryRenderer : EntryRenderer
    {
        public NoOutlineEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.Background = null;
        }
    }
}
