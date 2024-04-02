using Builder.MediaFiles;
using Builder.Word;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Builder.Converters;

public class TextConverter : IMediaConverter
{
    private TextFile testFile = new TextFile();
    public void ConvertImage(WordPicture pic)
    {
        var text = Extractor.ExtractTextFromPicture(pic);
        testFile.AddText(text);
    }
    public void ConvertParagraph(WordParagraph paragraph)
    {
        var text = string.Join(Environment.NewLine, paragraph.Lines);
        testFile.AddText(text);
    }
    public void ConvertTitle(WordTitle title)
    {
        testFile.AddText(title.Title);
    }

    public TextFile GetTextFile()
    {
        return testFile;
    }
}
