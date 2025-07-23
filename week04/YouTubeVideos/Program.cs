using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine($"These are my 3 current favorite songs to listen to!");
        Console.WriteLine("");

        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Soda Pop";
        video1._length = "150";
        video1._author = "Andrew Choi, NECKWAV, Kevin Woo, SamUIL Lee & Danny Chung";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "yutatata";
        video1Comment1._commentText = "the camera, the visual, the choreo, the SONG!! it's all done wholeheartedly by the team. This boy group might just become popular if they're real ww";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "sajjanmakwana9485";
        video1Comment2._commentText = "I'm totally obsessed with this  movie... All of us fans want part 2";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "asp11177";
        video1Comment3._commentText = "They had no business making it this catchy !!!";


        Video video2 = new Video();
        video2._title = "Gabriela";
        video2._length = "197";
        video2._author = "KATSEYE";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "lavenderthecrystalfury4808";
        video2Comment1._commentText = "This is SOOO catchy. Im happy this song was released";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "regularstan5789";
        video2Comment2._commentText = "Katseye doesn't follow a concept, they are the concept.";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "4rmyboy7";
        video2Comment3._commentText = "The most chaotic MV ever. The vocals are incredible";
        Comment video2Comment4 = new Comment();
        video2Comment4._name = "Poemwriter_Angelo";
        video2Comment4._commentText = "What a lovely song";



        Video video3 = new Video();
        video3._title = "Ready to Rock";
        video3._length = "219";
        video3._author = "BAND-MAID";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Bułagarage";
        video3Comment1._commentText = "Funny how these insane drums,  gathered all the rock people from around the world. Rock hard people!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Band-Maidfan";
        video3Comment2._commentText = "Miku is taking her guitar playing to the next level.";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "NickolasSHP";
        video3Comment3._commentText = "the fact that band maid that also made this song make this anime masterpiece";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "rajeevsat2000";
        video3Comment4._commentText = "Listened to this in a loop for an hour!!! That's a metal drummer right there. Bandmaid always delivers.";
        Comment video3Comment5 = new Comment();
        video3Comment5._name = "eramnesia3406";
        video3Comment5._commentText = "I never liked rock until I listened to Rock Is Lady's Modesty. It's so good that I even listen to it everyday.";


        //add comments to list for each video 
        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);
        video2._commentList.Add(video2Comment4);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);
        video3._commentList.Add(video3Comment5);


        //add each video to videosList 
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}