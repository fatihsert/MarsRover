namespace MarsRover.Model
{
    public class MarsRoverPositionModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Head { get; set; }

        public override string ToString()
        {
            return $"{X} {Y} {Head}";
        }
    }

}
