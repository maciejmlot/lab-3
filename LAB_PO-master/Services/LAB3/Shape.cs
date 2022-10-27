namespace WebApplication3.Services.LAB3
{
    public class Shape
    {
        public int Width;
        public int Height;

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetShorterSide()
        {
            return new List<int>() { Width, Height }.Min();
        }
    }
}
