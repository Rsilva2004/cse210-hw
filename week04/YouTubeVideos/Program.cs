using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        {
            video1._title = "...";
            video1._author = "...";
            video1._length = 2;
        }

        Comment comment1 = new Comment();
        {
            comment1._name = "...";
            comment1._comment = "...";
        }

           Video video2 = new Video();
        {
            video2._title = "...";
            video2._author = "...";
            video2._length = 2;
        }

        Comment comment2 = new Comment();
        {
            comment2._name = "...";
            comment2._comment = "...";
        }
           Video video3 = new Video();
        {
            video3._title = "...";
            video3._author = "...";
            video3._length = 2;
        }

        Comment comment3 = new Comment();
        {
            comment3._name = "...";
            comment3._comment = "...";
        }

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

     foreach (Video video in videos)
    {
      //Idk what i need to put here
    }
    }  
}


