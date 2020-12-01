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
    /// Логика взаимодействия для SolutionsPage.xaml
    /// </summary>
    public partial class SolutionsPage : Window
    {
        public SolutionsPage(Window owner)
        {
            InitializeComponent();
            this.Closed += SolutionsPage_Closed;
            var temp = this.Owner;
            this.Owner = owner;
            this.WindowStartupLocation = this.Owner.WindowStartupLocation;
            this.Owner.Effect = new System.Windows.Media.Effects.BlurEffect();
            this.Owner.IsEnabled = false;
        }

        public void AddSolutionToPanel(Solution sol)
        {
            nameRommUI.Text =  "Цена: " + sol.room.price.ToString() + " RUB";
            descrRoomUI.Text = string.Format("ID: {0} | Удобства: {1}", sol.room.id+1, sol.room.conviniences);

            foreach (Route item in sol.routes)
                StackPanelRoutes.Children.Add(new solutionRoutePlaceholder(item));
        }

        private void windowMovingEvent(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closePageEvent(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void SolutionsPage_Closed(object sender, EventArgs e)
        {
            Owner.IsEnabled = true;
            this.Owner.Effect = null;
        }
    }
}
