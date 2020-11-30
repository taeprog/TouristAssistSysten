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

        public MainWindow()
        {
            InitializeComponent();
            //DataInteractorPlaceholder нужно заменить на настоящий, когда Аскер его реализует
            interactor = new UIInteractor(new DataInteractorPlaceholder());

            // Решение, содержит комнату в которой польщователь остановится и список маршрутов по одному на каждый день его прибывания
            Solution sol = interactor.findRoomAndRoutes(10000, 5);
            //комната пользователя
            Room room = sol.room;
            // Отель в которо находится комната
            Hotel hotel = interactor.getHotel(room.hotelId);

            //список маршрутов, по одному на каждый день его прибывания
            List <Route> routes = sol.routes;
        }
    }
}
