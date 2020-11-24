using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouristAssistSistem.core.datagate;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem.core.uigate
{
    public class UIInteractor : IUIInteractor
    {

        private Solver solver;

        public UIInteractor(IDataInteractor dataInteractor) {
            solver = new Solver(dataInteractor);
        }

        public Solution findRoomAndRoutes(int money, int days)
        {
            return solver.findSolution(money, days);
        }

        public List<Hotel> getHotels()
        {
            return solver.getHotels();
        }

        public List<Room> getRooms(int hotelId)
        {
            return solver.getRooms(hotelId);
        }

        public List<Route> getRoutes()
        {
            return solver.getRoutes();
        }
    }
}
