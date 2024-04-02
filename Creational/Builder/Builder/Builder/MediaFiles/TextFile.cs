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
    public StringBuilder Text = new StringBuilder();

    public void AddText(string text)
    {
        Text.Append(text);
    }

    public void OpenText()
    {
        Console.WriteLine(Text.ToString());
    }

}
