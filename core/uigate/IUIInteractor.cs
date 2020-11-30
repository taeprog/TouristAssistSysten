using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem.core.uigate
{

    public interface IUIInteractor {
        List<Hotel> getHotels();
        Hotel getHotel(int hotelId);
        List<Room> getRooms(int hotelId);
        List<Route> getRoutes();
        Solution findRoomAndRoutes(int money, int days);  
    }
}
