// See https://aka.ms/new-console-template for more information
Video video = new()
{
    Title = "This Video.mp4"
};

VideoEncoder encoder = new VideoEncoder();
MessageService messageService = new();
EmailService emailService = new();

encoder.VideoEncoded += messageService.onVideoEncoded;
encoder.VideoEncoded += emailService.onVideoEncoded;

encoder.Encode(video);
