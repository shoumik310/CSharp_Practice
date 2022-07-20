// See https://aka.ms/new-console-template for more information
public class PhotoProcessor
{
    public delegate void PhotoFilterHandler(Photo photo);
    public void Process(string path, PhotoFilterHandler photoFilterHandler)
    {
        Photo photo = Photo.Load(path);
        photoFilterHandler(photo);
        
        photo.Save();
    }
}