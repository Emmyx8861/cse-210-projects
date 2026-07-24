using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
       Video video1 = new Video("ASMR","King lamo", 560);
       video1.AddComment(new Comment("Alice", "Love It."));
       video1.AddComment(new Comment("Emmy", "Nice Vid"));
       video1.AddComment(new Comment("Xavier"," Love the sounds"));

       Video video2 = new Video("Surfing","Jushy", 900);
       video2.AddComment(new Comment("Alex", "Wanna Go."));
       video2.AddComment(new Comment("Maeve", "Surfing cool"));
       video2.AddComment(new Comment("Nathan"," Love surfing"));
       //I used an encapsulation effect to simplify the process for the video details and adding comments to list//

       Video video3 = new Video("Streaming live","Raider", 780);
       video3.AddComment(new Comment("Suni", "Seding all my gifts"));
       video3.AddComment(new Comment("Axel", "Let's Play"));
       video3.AddComment(new Comment("Xander"," Later Gators"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            Console.WriteLine($"Title:{video.title}");
            Console.WriteLine();
            Console.WriteLine($"Author:{video.author}");
            Console.WriteLine();
            Console.WriteLine($"Length In Seconds:{video.lengthinseconds}");
            Console.WriteLine();
            Console.WriteLine($"Number Of Comments: {video.GetCommentCount() }");
            Console.WriteLine();
            Console.WriteLine($"Comments:");
            
            foreach (Comment comment in video.comments)
          {
             Console.WriteLine($"  - {comment.name}: {comment.text}");
          }

            Console.WriteLine();
        
        


       

      



       













    }
}}