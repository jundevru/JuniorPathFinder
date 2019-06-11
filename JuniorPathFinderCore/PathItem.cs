// Path Item

namespace JuniorPathFinderCore
{
    public class PathItem
    {
        private Vector3i point;
        private Layers layer;

        public Vector3i Point => point;
        public Layers Layer => layer;

        public PathItem(Vector3i point, Layers layer)
        {
            this.point = point;
            this.layer = layer;
        }

    }
}
