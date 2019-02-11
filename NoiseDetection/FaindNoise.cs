using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseDetection
{
    class FaindNoise
    {
        static private uint changePixels = 0;
        static private List<Point> myList = new List<Point>();
        public static Bitmap generateNoiseImage(string path)
        {
            Bitmap imageBMP =new Bitmap(Image.FromFile(path));
            imageBMP.Save("image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Bitmap imageBMPRed = imageBMP; 
            Bitmap imageJPG = (Bitmap)Image.FromFile("image.jpg");
            
            
            for (int i = 0; i < imageBMP.Width; i++)
            {
                for (int j = 0; j < imageBMP.Height; j++)
                {

                    if (imageBMP.GetPixel(i, j).R == imageJPG.GetPixel(i, j).R &&
                     imageBMP.GetPixel(i, j).G == imageBMP.GetPixel(i, j).G &&
                     imageBMP.GetPixel(i, j).B == imageBMP.GetPixel(i, j).B)
                    {

                    }
                    else
                    {
                        imageBMPRed.SetPixel(i, j, Color.Red);
                        changePixels++;

                        myList.Add(new Point(i,j));
                    }
                }
            }
            return imageBMPRed;
        }
       public uint getchangePixels()
        {
            return changePixels;
        }
       public List<Point> getList()
        {
            return myList;
        }

    }
}
