using System.Collections.Generic;
using System.Drawing;

namespace raytracing
{
    public class Scene
    {
        const int width = 40;
        const int height = 30;
        const int size = 8;

        private List<SceneObject> _objects;
        public Camera camera;

        public Scene()
        {

        }

        public void CreateSceneFromFile(string path)
        {
            _objects = new List<SceneObject>(width * height);
            Map map = new Map(width, height);
            map.ReadFromFile(path);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var brush = Brushes.Black;
                    switch (map.GetCell(j, i))
                    {
                        case 0x30: //pass
                            _objects.Add(new SceneObject(
                                new PointF(j * size, i * size),
                                size,
                                size));
                            break;
                        case 0x31: //white wall
                            _objects.Add(new Wall(
                                Brushes.Gray,
                                new PointF(j * size, i * size),
                                size,
                                size));
                            break;
                        case 0x32: //blue wall
                            _objects.Add(new Wall(
                                Brushes.Blue,
                                new PointF(j * size, i * size),
                                size,
                                size));
                            break;
                        case 0x33: //Yellow wall
                            _objects.Add(new Wall(
                                Brushes.Yellow,
                                new PointF(j * size, i * size),
                                size,
                                size));
                            break;
                        case 0x39:
                            camera = new Camera(
                                new PointF(j * size, i * size),
                                size);
                            break;
                    }
                }
            }
        }

        public void Render2D(Graphics graphics)
        {
            camera.CreateRays();

            foreach (var obj in _objects)
            {
                foreach(Ray ray in camera.rays)
                {
                    obj.Intersect(ray);
                }
                obj.Draw(graphics);
            }

            
            camera.Draw(graphics);
        }

        public void Render3D(Graphics graphics)
        {
            int x = 0;
            foreach(Ray ray in camera.rays)
            {
                int lineLength = 240 - (int)ray.length;
                graphics.DrawLine(new Pen(ray.color?? Brushes.Black), x, 120 + lineLength / 2, x, 120 - lineLength / 2);
                x++;
            }
        }
    }
}