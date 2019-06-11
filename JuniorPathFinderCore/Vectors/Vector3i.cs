using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPathFinderCore
{
    [System.Serializable]
    public struct Vector3i
    {
        public int x;
        public int y;
        public int z;
        public static readonly Vector3i zero = new Vector3i(0, 0, 0);
        


        public static bool AreNeighbours(Vector3i a, Vector3i b)
        {
            return (a.x == b.x || a.x == b.x + 1 || a.x == b.x - 1) &&
                    (a.y == b.y || a.y == b.y + 1 || a.y == b.y - 1) &&
                    (a.z == b.z || a.z == b.z + 1 || a.z == b.z - 1);
        }

        public static Vector3i GetNeighbourDirection(Vector3i a, Vector3i b)
        {
            return b - a;
        }

        public Vector3i(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3i(float x, float y, float z)
        {
            this.x = (int)x;
            this.y = (int)y;
            this.z = (int)z;
        }

        public static int DistanceSquared(Vector3i a, Vector3i b)
        {
            int dx = b.x - a.x;
            int dy = b.y - a.y;
            int dz = b.z - a.z;
            return dx * dx + dy * dy + dz * dz;
        }

        public int DistanceSquared(Vector3i v)
        {
            return DistanceSquared(this, v);
        }

        public static int FlatDistanceSquared(Vector3i a, Vector3i b)
        {
            int dx = b.x - a.x;
            int dz = b.z - a.z;
            return dx * dx + dz * dz;
        }

        public int FlatDistanceSquared(Vector3i v)
        {
            return FlatDistanceSquared(this, v);
        }

        public static float Distance(Vector3i a, Vector3i b)
        {
            int dx = b.x - a.x;
            int dy = b.y - a.y;
            int dz = b.z - a.z;
            return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public float Distance(Vector3i v)
        {
            return Distance(this, v);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode() << 2 ^ z.GetHashCode() >> 2;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector3i))
                return false;
            Vector3i vector = (Vector3i)other;
            return x == vector.x &&
                   y == vector.y &&
                   z == vector.z;
        }

        public override string ToString()
        {
            return "Vector3i(" + x + " " + y + " " + z + ")";
        }

        public static bool operator ==(Vector3i a, Vector3i b)
        {
            return a.x == b.x &&
                   a.y == b.y &&
                   a.z == b.z;
        }

        public static bool operator !=(Vector3i a, Vector3i b)
        {
            return a.x != b.x ||
                   a.y != b.y ||
                   a.z != b.z;
        }

        public static Vector3i operator -(Vector3i a, Vector3i b)
        {
            return new Vector3i(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector3i operator -(Vector3i a)
        {
            return new Vector3i(-a.x, -a.y, -a.z);
        }

        public static Vector3i operator +(Vector3i a, Vector3i b)
        {
            return new Vector3i(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3i operator *(Vector3i b, int a)
        {
            return new Vector3i(a * b.x, a * b.y, a * b.z);
        }
        /*
        public static Vector3 operator *(Vector3i b, float a)
        {
            return new Vector3(a * b.x, a * b.y, a * b.z);
        }

        public static implicit operator Vector3(Vector3i v)
        {
            return new Vector3(v.x, v.y, v.z);
        }
        */
        public static Vector3i operator *(int a, Vector3i b)
        {
            return new Vector3i(a * b.x, a * b.y, a * b.z);
        }

    }
}
