using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouristAssistSistem.core.datagate;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem.data
{
    class DataInteractorPlaceholder : IDataInteractor
    {
        public List<Hotel> getHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            hotels.Add(new Hotel(0, "name", "adress", "description"));
            hotels.Add(new Hotel(0, "name", "adress", "description"));
            hotels.Add(new Hotel(0, "name", "adress", "description"));
            hotels.Add(new Hotel(0, "name", "adress", "description"));
            return hotels;
        }

        public List<Room> getRooms()
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(0, 0, 1000, "удобства"));
            rooms.Add(new Room(0, 0, 1500, "удобства"));
            rooms.Add(new Room(0, 0, 1300, "удобства"));
            rooms.Add(new Room(0, 0, 3500, "удобства"));
            rooms.Add(new Room(0, 0, 4000, "удобства"));
            rooms.Add(new Room(0, 0, 4500, "удобства"));

            return rooms;
        }

        public List<Route> getRoutes()
        {
            List<Route> routes = new List<Route>();
            routes.Add(new Route(0, "Маршрут", 5, 50, 1, 500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 5, 50, 1, 500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 5, 50, 1, 500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 5, 50, 1, 500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 10, 50, 2, 1500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 10, 50, 2, 1500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 10, 50, 2, 1500, "asdasdasdasdasd"));
            routes.Add(new Route(0, "Маршрут", 20, 50, 3, 2000, "asdasdasdasdasd"));
            return routes;
        }
    }
}
