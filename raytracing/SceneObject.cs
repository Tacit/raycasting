using System.Drawing;

namespace raytracing
{
    public class SceneObject
    {
        public PointF position;
        public float width;
        public float height;
        public Brush color = Brushes.Black;
        public bool isSolid = false;

        public SceneObject(PointF position, float width, float height)
        {
            this.position = position;
            this.width = width;
            this.height = height;
        }

        virtual public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(color,
                            new Rectangle(
                                (int)position.X,
                                (int)position.Y,
                                (int)width,
                                (int)height));
        }

        virtual public PointF? Intersect(Ray ray)
        {
            return null;
        }

    }
}
