using AbstractFactory.Frameworks.Base;
using AbstractFactory.Frameworks.Material;
using AbstractFactory.Frameworks.Factories;

namespace AbstractFactory.Frameworks.Factories;

public class MaterialViewFactory : IViewFactory
{
    public IButton CreateButton()
    {
        return new MaterialButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MaterialTextBox();
    }
}
