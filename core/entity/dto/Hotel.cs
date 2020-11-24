namespace TouristAssistSistem.core.entity
{
    public class Hotel
    {
        public int id;
        public string name;
        public string address;
        public string description;

        public Hotel()
        {
        }

        public Hotel(int id, string name, string address, string description)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.description = description;
        }
    }
}
