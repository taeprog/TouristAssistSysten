using System;
using System.Collections.Generic;
using TouristAssistSistem.core.entity;

namespace TouristAssistSistem.core.entity
{
    class Selector
    {
        private List<Room> rooms;
        private List<Route> routes;

        public Selector(List<Room> rooms, List<Route> routes)
        {
            this.rooms = rooms;
            this.rooms.Sort((a, b) => { return ((a.price) >= (b.price)) ? 1 : 0; });
            this.routes = routes;
            this.routes.Sort((a, b) => { return (a.cost >= b.cost) ? 1 : 0; });
        }

        public Solution findSolution(int money, int days) 
        {
            Queue<Route> hard = new Queue<Route>();
            Queue<Route> medium = new Queue<Route>();
            Queue<Route> light = new Queue<Route>();

            List<Route> result = new List<Route>();

            routes.ForEach((a) =>
            {
                if (a.difficulty == 3) hard.Enqueue(a);
                else if (a.difficulty == 2) medium.Enqueue(a);
                else light.Enqueue(a);
            });

            float minRoomPrice = (rooms[0].price)*(days-1);
            float actionMoney = money - minRoomPrice;
            float actionMaxDayMoney = actionMoney / days;

            List<Route> affordableRoutes = routes.FindAll((a) => { return a.cost <= actionMaxDayMoney; });
            List<int> routeNumbers = new List<int>();
            for (int i = 0; i < affordableRoutes.Count; i++) {
                routeNumbers.Add(i);
            }

            Random rand = new Random();

            for (int i = 0; i < days && routeNumbers.Count>0; i++) {
                int selRoute = routeNumbers[rand.Next(0, routeNumbers.Count)];
                result.Add(affordableRoutes[selRoute]);
                routeNumbers.Remove(selRoute);
            }

            float resultActionMoney = 0;
            result.ForEach((a) => { resultActionMoney += a.cost; });
            float roomPrice = minRoomPrice + (actionMoney - resultActionMoney);

            List<Room> affordableRooms = rooms.FindAll((a) => { return a.price * (days - 1) <= roomPrice; });
            Room room = affordableRooms[affordableRooms.Count - 1];


            return new Solution(room, result);
        }


    }
}
