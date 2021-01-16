using System;

namespace DesignPatterns_TheFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Image> images = new List<Image>();
            images.Add(new JpegImage());
            images.Add(new GifImage());
            ImageCollection imageRepository = new ImageCollection(images);
            Console.WriteLine(imageRepository.CreateThumbnails());
        }
    }
}
