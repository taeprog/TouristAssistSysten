using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem
{

    public partial class HotelsPage : Window
    {
        public HotelsPage(Window owner)
        {
            InitializeComponent();
            this.Closed += HotelsPage_Closed;
            var temp = this.Owner;
            this.Owner = owner;
            this.WindowStartupLocation = this.Owner.WindowStartupLocation;
            this.Owner.Effect = new System.Windows.Media.Effects.BlurEffect();
            this.Owner.IsEnabled = false;
        }





        public void AddHotelToPanel(Hotel hotel,List<Room> rooms)
        {
            StackPanel.Children.Add(new hotelPlaceholder(hotel,rooms));
        }

        private void windowMovingEvent(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        

        private void closePageEvent(object sender, RoutedEventArgs e)
        {
            Close();
                
        }

        private void HotelsPage_Closed(object sender, EventArgs e)
        {
            Owner.IsEnabled = true;
            this.Owner.Effect = null;

        }
    }
}
