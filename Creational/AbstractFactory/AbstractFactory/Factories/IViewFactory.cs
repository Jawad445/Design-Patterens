using AbstractFactory.Frameworks.Base;

namespace AbstractFactory.Frameworks.Factories;

public interface IViewFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}
