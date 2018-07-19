using System.Drawing;

namespace raytracing
{
    public class Wall : SceneObject
    {
        public Wall(Brush color, PointF position, float width, float heigh) : base(position, width, heigh)
        {
            this.color = color;
            isSolid = false;
        }



        override public PointF? Intersect(Ray ray)
        {
            float length = ray.length;
            PointF? result = null;
            //top
            result = IntersectWithSide(ray,
                                        position,
                                        new PointF(position.X + width, position.Y),
                                        ref length,
                                        result);

            //bottom

            result = IntersectWithSide(ray,
                                       new PointF(position.X, position.Y + height),
                                       new PointF(position.X + width, position.Y + height),
                                       ref length,
                                       result);

            //left
            result = IntersectWithSide(ray,
                                       position,
                                        new PointF(position.X, position.Y + height),
                                       ref length,
                                       result);


            //Right
            result = IntersectWithSide(ray,
                                       new PointF(position.X + width, position.Y),
                                        new PointF(position.X + width, position.Y + height),
                                       ref length,
                                       result);


            if (result != null)
            {
                ray.MeasureEndPoint(result);
                ray.color = this.color;
            }

            return result;
        }

        private PointF? IntersectWithSide(Ray ray, PointF Start, PointF end, ref float prevLength, PointF? prevResult)
        {
            float length;
            PointF? result = prevResult;
            PointF? point = MathHelper.IntersectToLines(Start, end, ray.startPoint, ray.endPoint);
            if (point != null)
            {
                length = ray.MeasureEndPoint(point);
                if (length < prevLength)
                {
                    prevLength = length;
                    result = point;
                }
            }

            return result;
        }
    }
}
