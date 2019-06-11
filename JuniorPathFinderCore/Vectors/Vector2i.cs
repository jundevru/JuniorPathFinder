using System;

namespace JuniorPathFinderCore
{
    [System.Serializable]
    public struct Vector2i
    {
        public int x;
        public int y;
        public static readonly Vector2i zero = new Vector2i(0, 0);


        public static bool AreNeighbours(Vector2i a, Vector2i b)
        {
            return (a.x == b.x || a.x == b.x + 1 || a.x == b.x - 1) &&
                    (a.y == b.y || a.y == b.y + 1 || a.y == b.y - 1);
        }

        public static Vector3i GetNeighbourDirection(Vector3i a, Vector3i b)
        {
            return b - a;
        }

        public Vector2i(int x, int z)
        {
            this.x = x;
            this.y = z;
        }

        public Vector2i(float x, float z)
        {
            this.x = (int)x;
            this.y = (int)z;
        }

        public static int DistanceSquared(Vector2i a, Vector2i b)
        {
            int dx = b.x - a.x;
            int dz = b.y - a.y;
            return dx * dx + dz * dz;
        }

        public int DistanceSquared(Vector2i v)
        {
            return DistanceSquared(this, v);
        }

        public static float Distance(Vector2i a, Vector2i b)
        {
            int dx = b.x - a.x;
            int dz = b.y - a.y;
            return (float)Math.Sqrt(dx * dx + dz * dz);
        }

        public float Distance(Vector2i v)
        {
            return Distance(this, v);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode() << 2 ^ y.GetHashCode() >> 2;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector3i))
                return false;
            Vector3i vector = (Vector3i)other;
            return x == vector.x &&
                   y == vector.z;
        }

        public override string ToString()
        {
            return "Vector2i(" + x + " " + y + ")";
        }

        public static bool operator ==(Vector2i a, Vector2i b)
        {
            return a.x == b.x &&
                   a.y == b.y;
        }

        public static bool operator !=(Vector2i a, Vector2i b)
        {
            return a.x != b.x ||
                   a.y != b.y;
        }

        public static Vector2i operator -(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.x - b.x, a.y - b.y);
        }

        public static Vector2i operator -(Vector2i a)
        {
            return new Vector2i(-a.x, -a.y);
        }

        public static Vector2i operator +(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.x + b.x, a.y + b.y);
        }

        public static Vector2i operator *(Vector2i b, int a)
        {
            return new Vector2i(a * b.x, a * b.y);
        }

        public static Vector2i operator *(int a, Vector2i b)
        {
            return new Vector2i(a * b.x, a * b.y);
        }

    }
}
