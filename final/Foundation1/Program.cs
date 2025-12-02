using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Samoan Culture 101", "IslandLife", 240);
        v1.AddComment(new Comment("Jay", "Loved this video!"));
        v1.AddComment(new Comment("Tia", "Very educational."));
        v1.AddComment(new Comment("Mika", "Thanks for sharing!"));
        videos.Add(v1);

        Video v2 = new Video("How to Cook Palusami", "AuntyLani", 360);
        v2.AddComment(new Comment("Sara", "My favorite dish!"));
        v2.AddComment(new Comment("Tom", "Trying this today."));
        v2.AddComment(new Comment("Lia", "Looks delicious!"));
        videos.Add(v2);

        Video v3 = new Video("Island Dance Tutorial", "FiafiaCrew", 180);
        v3.AddComment(new Comment("Lua", "This was fun!"));
        v3.AddComment(new Comment("Ben", "Great explanation."));
        v3.AddComment(new Comment("Rei", "Practicing now!"));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }
    }
}
