using System.Collections.Generic;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem.core.datagate
{
    public interface IDataInteractor
    {
        List<Room> getRooms();
        List<Hotel> getHotels();
        List<Route> getRoutes();
    }
}
