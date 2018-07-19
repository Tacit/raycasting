using System;
using System.Drawing;

namespace raytracing
{
    public static class MathHelper
    {
        public static PointF RotatePoint(PointF pointToRotate, PointF centerPoint, float angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new PointF
            (
                (float)(cosTheta * (pointToRotate.X - centerPoint.X) - 
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                (float)(sinTheta * (pointToRotate.X - centerPoint.X) + 
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            );
        }

        public static PointF? IntersectToLines(PointF ls1, PointF le1, PointF ls2, PointF le2)
        {
            PointF? result = null;
            float s1_x, s1_y, s2_x, s2_y;
            s1_x = le1.X - ls1.X;
            s1_y = le1.Y - ls1.Y;
            s2_x = le2.X - ls2.X;
            s2_y = le2.Y - ls2.Y;

            float s, t;
            s = (-s1_y * (ls1.X - ls2.X) + s1_x * (ls1.Y - ls2.Y)) / (-s2_x * s1_y + s1_x * s2_y);
            t = (s2_x * (ls1.Y - ls2.Y) - s2_y * (ls1.X - ls2.X)) / (-s2_x * s1_y + s1_x * s2_y);

            if (s >= 0 && s <= 1 && t >= 0 && t <= 1)
            {
                // Collision detected
                result = new PointF(ls1.X + (t * s1_x), ls1.Y + (t * s1_y));
            }

            return result;
        }
    }
}
