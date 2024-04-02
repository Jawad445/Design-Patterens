using Builder.Helper;
using Builder.MediaFiles;
using Builder.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Converters;

public class AudioConverter: IMediaConverter
{
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

    public AudioFile GetAudioFile()
    {
        return AudioHelper.JoinAudio(tempPaths);
    }
}
