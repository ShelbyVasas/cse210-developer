namespace Unit04.Game.Casting
{
    //purpose is to hold a point value
    public class FallingObject : Actor
    {
        private int pointVal;
        public FallingObject(int points)
        {
            pointVal = points;
        }

        //returns a point value
        public int getPoints()
        {
            return pointVal;
        }
    }
}