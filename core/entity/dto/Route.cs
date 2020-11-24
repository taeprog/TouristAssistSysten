namespace TouristAssistSistem.core.entity
{
    public class Route
    {
        public int id;
        public string name;
        public float distance;
        public float heightDiff;
        public int difficulty;
        public float cost;
        public string information;

        public Route()
        {
        }

        public Route(int id, string name, float distance, float heightDiff, int difficulty, float cost, string information)
        {
            this.id = id;
            this.name = name;
            this.distance = distance;
            this.heightDiff = heightDiff;
            this.difficulty = difficulty;
            this.cost = cost;
            this.information = information;
        }
    }
}
