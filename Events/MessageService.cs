// See https://aka.ms/new-console-template for more information



public class MessageService
{
    //Naming convention: same name as event call
    //public void onVideoEncoded(object source, EventArgs eventArgs)
    //{
    //    Console.WriteLine("MessageService: Sending an Message... ");
    //}

    public void onVideoEncoded(object source, VideoEventArgs args
        )
    {
        Console.WriteLine("MessageService: Sending an Message... " + args.Video.Title);
    }
}