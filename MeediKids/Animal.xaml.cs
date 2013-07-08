using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MeediKids
{
    public sealed partial class Animal : UserControl
    {
        public static readonly DependencyProperty ActivationTextProperty = DependencyProperty.Register("ActivationText", typeof(string), typeof(Animal), null);

        public string ActivationText
        {
            get { return (string) GetValue(ActivationTextProperty); }
            set { SetValue(ActivationTextProperty, value); }
        }

        private DispatcherTimer timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(1) };

        public Animal()
        {
            this.InitializeComponent();
            timer.Tick += timer_Tick;
        }

        private void OnPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Active", true);

            SoundPlayer.Play();

            timer.Start();
        }

        void timer_Tick(object sender, object e)
        {
            timer.Stop();
            VisualStateManager.GoToState(this, "Normal", false);
        }
    }
}
