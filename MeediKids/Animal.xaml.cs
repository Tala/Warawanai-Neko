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
        
        public Animal()
        {
            this.InitializeComponent();
        }

        private void OnPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Clicked", true);
            //var uri = new System.Uri("ms-appx:///Assets/Animals/animal_clicked.png");
            //AnimalImage.Source = new BitmapImage(uri);
        }
    }
}
