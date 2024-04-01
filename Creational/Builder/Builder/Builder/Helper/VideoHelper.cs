using Builder.MediaFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Helper;

public static class VideoHelper
{

    public static string GenerateVideo(string text)
    {
        return "C:\\Video1";
    }
    public static VideoFile JoinVideo(List<string> path) { 
        VideoFile file = new VideoFile();
        for (int i = 0; i < path.Count; i++)
        {
            Console.WriteLine($"Video {i}");
        }
        return file;
    }

}
