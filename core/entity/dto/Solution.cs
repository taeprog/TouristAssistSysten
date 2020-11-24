using System.Collections.Generic;

namespace TouristAssistSistem.core.entity
{
    public class Solution
    {
        Room room;
        List<Route> routes;

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
