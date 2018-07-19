using System.IO;

namespace raytracing
{
    public class Map
    {
        private byte[,] _map;
        private int _width;
        private int _height;

        public Map(int width, int height)
        {
            this._width = width;
            this._height = height;
            _map = new byte[height, width];
        }

        public void ReadFromFile(string path)
        {
            byte[] map = new byte[_width * _height];
            int k = 0;

            foreach( byte b in File.ReadAllBytes(path))
            {
                if (b != '\n' && b != '\r')
                {
                    map[k] = b;
                    k++;
                }
            }
           
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    _map[i, j] = map[i * _width + j];
                }
            }
        }

        public byte GetCell(int x, int y)
        {
            return _map[y, x];
        }
    }
}
