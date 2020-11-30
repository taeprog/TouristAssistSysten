namespace TouristAssistSistem.core.entity
{
    public class Room
    {
        public int id;
        public int hotelId;
        public float price;
        public string conviniences; // удобства

        public Room()
        {
        }

        public Room(int id, int hotelId, float price, string conviniences)
        {
            this.id = id;
            this.hotelId = hotelId;
            this.price = price;
            this.conviniences = conviniences;
        }


    }
}
