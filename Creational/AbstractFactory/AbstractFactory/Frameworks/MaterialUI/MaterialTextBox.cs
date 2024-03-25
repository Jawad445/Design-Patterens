using AbstractFactory.Frameworks.Base;

namespace AbstractFactory.Frameworks.Material;

public class MaterialTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering Material TextBox");
    }
}
