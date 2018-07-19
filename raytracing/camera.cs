using System.Collections.Generic;
using System.Drawing;

namespace raytracing
{
    public class Camera : SceneObject
    {
        private PointF _cameraPosition;
        private int _size = 8;
        private Brush _cameraBrush = Brushes.Red;
        private PointF[] _polygonPoints;
        private PointF _cameraCenter;
        private float _fov = 60;
        public List<Ray> rays;
        private float _rayStep;
        private int _viewPortWidth = 320;
        private int _viewPortHeight = 240;


        public float viewangle = 0;

        public Camera(PointF position, int size) : base(position, size, size)
        {
            this._size = size;
            SetPosition(position);
            rays = new List<Ray>(_viewPortWidth);
            _rayStep = _fov / _viewPortWidth;
        }

        public void SetPosition(PointF position)
        {
            this._cameraPosition = position;

            _polygonPoints = new PointF[] {
                                new PointF(_cameraPosition.X + 2, _cameraPosition.Y + _size - 1),
                                new PointF(_cameraPosition.X + (_size /2), _cameraPosition.Y + 2 ),
                                new PointF(_cameraPosition.X + _size-2, _cameraPosition.Y + _size -1)};

            _cameraCenter = new PointF(_cameraPosition.X + _size / 2, _cameraPosition.Y + _size / 2);
        }

        public void CreateRays()
        {
            rays.Clear();

            for (float i = _fov / 2 * -1 ; i < _fov / 2; i += _rayStep)
            {
                rays.Add(new Ray(_cameraCenter, viewangle + i, _viewPortWidth));
            }

        }

        private void RenderRays(Graphics graphics)
        {
            
            foreach (Ray ray in rays)
                ray.Draw(graphics);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Black,
                                    new Rectangle((int)_cameraPosition.X, 
                                                  (int)_cameraPosition.Y, 
                                                  _size, 
                                                  _size));

            RenderRays(graphics);

            PointF[] rpoints = new PointF[3];
            for (int i = 0; i < this._polygonPoints.Length; i++)
            {
                rpoints[i] = MathHelper.RotatePoint(_polygonPoints[i], _cameraCenter, viewangle);
            }

            graphics.DrawPolygon(new Pen(_cameraBrush),
                                    rpoints);
        }
    }
}
