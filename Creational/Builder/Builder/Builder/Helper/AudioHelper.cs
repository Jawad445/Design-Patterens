using Builder.MediaFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Helper;

public static class AudioHelper
{
    public static string GenerateAudio(string text)
    {
        return "C:\\Audio1";
    }
    public static AudioFile JoinAudio (List<string> path) {
        AudioFile file = new AudioFile();
        for (int i = 0; i < path.Count; i++)
        {
            Console.WriteLine($"Audio {i}");
        }
        return file;
    }

    
}
