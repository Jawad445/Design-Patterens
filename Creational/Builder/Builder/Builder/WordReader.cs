using Builder.Converters;
using Builder.MediaFiles;
using Builder.Word;
using Microsoft.VisualBasic.FileIO;

namespace Builder;

public class WordReader
{
    public void Convert(WordDocument doc, IMediaConverter media)
    {

        foreach (var item in doc.Body)
        {
            if (item is WordTitle)
            {
                media.ConvertTitle(item as WordTitle);
            }
            else if (item is WordParagraph)
            {
                media.ConvertParagraph(item as WordParagraph);
            }
            else if (item is WordPicture)
            {
                media.ConvertImage(item as WordPicture);
            }
        }
    }
}
