using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_TheFactoryMethod
{
    public class Thumbnail
    {
        // ...
    }

    public interface Image
    {
        Thumbnail CreateThumbnail();
    }

    public class GifImage : Image
    {
        public Thumbnail GetThumbnail()
        {
            // ... Create a GIF thumbnail here ...
            return gifThumbnail;
        }
    }

    public class JpegImage : Image
    {
        public Thumbnail GetThumbnail()
        {
            //... Create a JPEG thumbnail here ...
            return jpegThumbnail;
        }
    }

    public class ImageCollection
    {
        private IList<Image> images;

        public ImageCollection(IList<Image> images)
        {
            this.images = images;
        }
    }

    public IList<Thumbnail> CreateThumbnails()
    {
        IList<Thumbnail> thumbnails = new List<Thumbnail>(images.Count);
        foreach (Image thumb in images)
        {
            thumbnails.Add(thumb.CreateThumbnail());
        }
        return thumbnails;
    }
}
