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
            return new List<Hotel>();
        }

        public List<Room> getRooms()
        {
            return new List<Room>();
        }

        public List<Route> getRoutes()
        {
            return new List<Route>();
        }
    }
}
