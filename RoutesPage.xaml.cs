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
using TouristAssistSistem.uiElements;

namespace TouristAssistSistem
{
    /// <summary>
    /// Логика взаимодействия для RoutesPage.xaml
    /// </summary>
    public partial class RoutesPage : Window
    {
        public RoutesPage(Window owner)
        {
            InitializeComponent();
            this.Closed += RoutesPage_Closed;
            var temp = this.Owner;
            this.Owner = owner;
            this.WindowStartupLocation = this.Owner.WindowStartupLocation;
            this.Owner.Effect = new System.Windows.Media.Effects.BlurEffect();
            this.Owner.IsEnabled = false;
        }

        public void AddRouteToPanel(List<Route> routes)
        {
            foreach(Route item in routes)
                StackPanel.Children.Add(new routePlaceholder(item));
        }

        private void windowMovingEvent(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closePageEvent(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void RoutesPage_Closed(object sender, EventArgs e)
        {
            Owner.IsEnabled = true;
            this.Owner.Effect = null;
        }
    }
}
