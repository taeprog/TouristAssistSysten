using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouristAssistSistem.core.datagate;

namespace TouristAssistSistem.core.entity
{
    public class Solver
    {
        private IDataInteractor dataInteractor;
        private List<Hotel> hotels;
        private List<Room> rooms;
        private List<Route> routes;
        private Selector selector;
        public Solver(IDataInteractor dataInteractor)
        {
            this.dataInteractor = dataInteractor;
            hotels = dataInteractor.getHotels();
            rooms = dataInteractor.getRooms();
            routes = dataInteractor.getRoutes();

            selector = new Selector(rooms, routes);
        }


        public List<Hotel> getHotels() {
            return hotels;
        }

        public List<Room> getRooms(int hotelId) {
            return rooms.FindAll((a) => { return a.hotelId == hotelId; });
        }

        public List<Route> getRoutes() {
            return routes;
        }

        public Solution findSolution(int money, int days) {
            return selector.findSolution(money, days);
        }

    }
}
