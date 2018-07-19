using System;
using System.Drawing;

namespace raytracing
{
    public class Ray
    {
        public PointF startPoint;
        public float length;
        private float _maxLenght;
        public PointF endPoint;
        private float _angle;
        public Brush color;

        public Ray(PointF start, float angle, float maxLength)
        {
            startPoint = start;
            _angle = angle;
            _maxLenght = maxLength;
            MeasureEndPoint(null);
        }

        public float MeasureEndPoint(PointF? point)
        {
            if (point == null)
            {
                PointF direct = new PointF(startPoint.X, startPoint.Y - _maxLenght);
                endPoint = MathHelper.RotatePoint(direct, startPoint, _angle);
                length = (float)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
            }    
            else
            {
                endPoint = point.Value;
                length = (float)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
            }
            return length;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pens.Aqua, startPoint, endPoint);
        }
    }
}
