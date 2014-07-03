namespace PseudoBF.MachineModel
{
    public class Location
    {
        private int location;

        public Location(int location)
        {
            this.location = location;
        }

        public static int Offset(Location current, Location target)
        {
            return target.location - current.location;
        }

        public override bool Equals(object obj)
        {
            return (obj != null && obj.GetType() == typeof(Location)
                && (obj as Location).location == this.location);
        }

        public override int GetHashCode()
        { return location.GetHashCode(); }

        public int InternalPosition
        { get { return location; } }
    }
}
