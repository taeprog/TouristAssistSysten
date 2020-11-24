namespace TouristAssistSistem.core.entity
{
    public class Room
    {
        public int id;
        public int hotelId;
        public float price;
        public string conviniences;
        public int places;
        public float foodCost;

        public Room()
        {
        }

        public Room(int id, int hotelId, float price, string conviniences, int places, float foodCost)
        {
            this.id = id;
            this.hotelId = hotelId;
            this.price = price;
            this.conviniences = conviniences;
            this.places = places;
            this.foodCost = foodCost;
        }


    }
}
