namespace MyPoint3D
{
    public class Point3d
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3d() { }

        public Point3d(double pointX, double pointY, double pointZ)
        {
            X = pointX;
            Y = pointY;
            Z = pointZ;
        }


        public override bool Equals(object? obj)
        {
            if (this == obj) return true;

            Point3d? other = obj as Point3d;

            if (other is null) return false;

            else if (!X.Equals(other.X) || !Y.Equals(other.Y) || !Z.Equals(other.Z))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int result = (int)Math.Round((X + Y + Z));
            return result;
        }

        public override string ToString()
        {
            return string.Format($"X={X} Y={Y} Z={Z}");
        }

    }
}
