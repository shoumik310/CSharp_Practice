// See https://aka.ms/new-console-template for more information



public class EmailService
{
    //Naming convention: same name as event call
    //public void onVideoEncoded(object source, EventArgs eventArgs)
    //{
    //    Console.WriteLine("EmailService: Sending an Email... ");
    //}

    public void onVideoEncoded(object source, VideoEventArgs args)
    {
        Console.WriteLine("EmailService: Sending an Email... " + args.Video.Title);
    }
}
