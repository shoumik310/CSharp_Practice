
// See https://aka.ms/new-console-template for more information
public class Photo
{
    public string Path { get; set; }

    public static Photo Load(string path)
    {
        Photo photo = new Photo()
        {
            Path = path
        };


        return photo;
    }

    public void Save()
    {
        Console.WriteLine("Photo Saved");
    }

}
