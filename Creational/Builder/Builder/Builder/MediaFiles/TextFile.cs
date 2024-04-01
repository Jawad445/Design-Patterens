using Builder.Helper;
using Builder.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Builder.MediaFiles;

public class TextFile
{
    private StringBuilder Text = new StringBuilder();

    public void ConvertImage(WordPicture pic)
    {
        var text = Extractor.ExtractTextFromPicture(pic);
        Text.AppendLine(text);
    }
    public void ConvertParagraph(WordParagraph paragraph)
    {
        var text = string.Join(Environment.NewLine, paragraph);
        Text.AppendLine(text);
    }
    public void ConvertTitle(WordTitle title)
    {
        Text.AppendLine(title.Title);
    }

    public void OpenText()
    {
        Console.WriteLine(Text.ToString());
    }

}
