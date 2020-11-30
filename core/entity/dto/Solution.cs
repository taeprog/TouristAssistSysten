using System.Collections.Generic;

namespace TouristAssistSistem.core.entity
{
    public class Solution
    {
        public Room room;
        public List<Route> routes;

        public Solution()
        {
        }

        public Solution(Room room, List<Route> routes)
        {
            this.room = room;
            this.routes = routes;
        }


    }
}
