using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TouristAssistSistem.core.datagate;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem.data
{
    class DataInteractor : IDataInteractor
    {
        public List<Hotel> getHotels()
        {
            return File.ReadAllLines("hotels.txt", Encoding.UTF8)
                    .Select(v => {
                        var columns = v.Split('\t');
                        return new Hotel(
                            int.Parse(columns[0]),
                            columns[1],
                            columns[2],
                            columns[3]);
                    }).ToList();
        }

        public List<Room> getRooms()
        {
            Regex regex = new Regex("\\D");

            return File.ReadAllLines("rooms.txt", Encoding.UTF8)
                    .Select(v => {
                        var columns = v.Split('\t');
                        return new Room(
                            int.Parse(columns[1]),
                            int.Parse(columns[0]),
                            float.Parse(regex.Replace(columns[2], "")),
                            columns[3]);
                    }).ToList();
        }

        public List<Route> getRoutes()
        {
            return File.ReadAllLines("routes.txt", Encoding.UTF8)
                   .Select(v => {
                       var columns = v.Split('\t');
                       return new Route(
                           int.Parse(columns[0]),
                           columns[1],
                           float.Parse(columns[2]),
                           float.Parse(columns[3]),
                           int.Parse(columns[5]),
                           float.Parse(columns[4]),
                            ""
                           );
                   }).ToList();
        }
    }
}
