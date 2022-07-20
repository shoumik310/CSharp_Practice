// See https://aka.ms/new-console-template for more information
public class VideoEncoder
{
    // 1 - Define a Delegate
    // 2 - Define and event based on this delegate
    // 3 - Raise the event

    //Naming convention is 'EventName'EventHandler(object source, EventArgs eventArgs);
    public delegate void VideoEncodedEventHandler(object source, EventArgs eventArgs);
    
    public event VideoEncodedEventHandler VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding Video...");
        Thread.Sleep(3000);

        OnVideoEncoded();
    }

    //Naming Convention: protected virtual void On'EventName'()
    protected virtual void OnVideoEncoded()
    {
        if (VideoEncoded != null)
            VideoEncoded(this, EventArgs.Empty);
    }
}
