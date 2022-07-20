// See https://aka.ms/new-console-template for more information
public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}
public class VideoEncoder
{
    // 1 - Define a Delegate
    // 2 - Define and event based on this delegate
    // 3 - Raise the event

    //--Naming convention is 'EventName'EventHandler(object source, EventArgs eventArgs);
    //public delegate void VideoEncodedEventHandler(object source, EventArgs eventArgs);

    //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // To sent data with event

    //public event VideoEncodedEventHandler VideoEncoded;

    //public event EventHandler VideoEncoded; 
    public event EventHandler<VideoEventArgs> VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding Video...");
        Thread.Sleep(3000);

        OnVideoEncoded(video);
    }

    //--Naming Convention: protected virtual void On'EventName'()
    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            //VideoEncoded(this, EventArgs.Empty);
            VideoEncoded(this, new VideoEventArgs()
            {
                Video = video
            }
            );
    }
}
