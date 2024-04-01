using Builder.Helper;
using Builder.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.MediaFiles;

public class AudioFile
{
    public string Format { get; set; }
    public List<string> tempPaths { get; set; } = new List<string>();

    public void ConvertImage(WordPicture picture)
    {
        var text = Extractor.ExtractTextFromPicture(picture);
        var generatedAudio = AudioHelper.GenerateAudio(text);
        tempPaths.Add(generatedAudio);
    }
    public void ConvertParagraph(WordParagraph paragraph)
    {
        var text = string.Join(Environment.NewLine, paragraph);
        var generatedAudio = AudioHelper.GenerateAudio(text);
        tempPaths.Add(generatedAudio);
    }
    public void ConvertTitle(WordTitle title)
    {
        var generatedAudio = AudioHelper.GenerateAudio(title.Title);
        tempPaths.Add(generatedAudio);
    }

    public void openAudio()
    {
        for (int i = 0; i < tempPaths.Count; i++)
        {
            Console.WriteLine($"Joining Audio Files {i}");
        }
        Console.WriteLine("Playing Audio");
    }
}
