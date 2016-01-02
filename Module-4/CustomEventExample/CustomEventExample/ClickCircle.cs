using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace CustomEventExample
{
    public sealed class ClickCircle : Control
    {
        public event EventHandler<MessageEventArgs> Click;

        private void Circle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Click != null)
            {
                var device = e.PointerDeviceType.ToString();
                var eventArgs = new MessageEventArgs($"This control was clicked by: {device}");
                Click(sender, eventArgs);
            }
        }

        public ClickCircle()
        {
            this.DefaultStyleKey = typeof(ClickCircle);
            this.Tapped += Circle_Tapped;
        }
    }
}
