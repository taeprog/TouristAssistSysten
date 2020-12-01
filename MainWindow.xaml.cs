using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TouristAssistSistem.core.entity;
using TouristAssistSistem.core.uigate;
using TouristAssistSistem.data;

namespace TouristAssistSistem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IUIInteractor interactor;
        public Frame pageFrame;

        public MainWindow()
        {
            InitializeComponent();

            //DataInteractorPlaceholder нужно заменить на настоящий, когда Аскер его реализует
            interactor = new UIInteractor(new DataInteractor());

            // Решение, содержит комнату в которой польщователь остановится и список маршрутов по одному на каждый день его прибывания
            Solution sol = interactor.findRoomAndRoutes(10000, 5);
            //комната пользователя
            Room room = sol.room;
            // Отель в которо находится комната
            Hotel hotel = interactor.getHotel(room.hotelId);



            //список маршрутов, по одному на каждый день его прибывания
            List<Route> routes = sol.routes;

        }
        private void windowMovingEvent(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void exitProgramEvent(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void showHotelsPage(object sender, RoutedEventArgs e)
        {
            var hotelsPage = new HotelsPage(this);
            foreach (Hotel item in interactor.getHotels())
            {
                hotelsPage.AddHotelToPanel(item, interactor.getRooms(item.id));
            }
            hotelsPage.Show();
        }

        private void showRoutesPage(object sender, RoutedEventArgs e)
        {
            var routesPage = new RoutesPage(this);
            routesPage.AddRouteToPanel(interactor.getRoutes());
            routesPage.Show();
        }

        private void showSolutionsPage(object sender, RoutedEventArgs e)
        {
            if (daysUI.Text != string.Empty && cashUI.Text != string.Empty)
            {
                var solutionsPage = new SolutionsPage(this);
                var solutions = interactor.findRoomAndRoutes(Convert.ToInt32(cashUI.Text), Convert.ToInt32(daysUI.Text));
                solutionsPage.AddSolutionToPanel(solutions);
                solutionsPage.Show();
                   }
            else
            {
                MessageBox.Show("Введите ваш бюджет и кол-во дней!", "Внимание");
            }
        }
    }
}
