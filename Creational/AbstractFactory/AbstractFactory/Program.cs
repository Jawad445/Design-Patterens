using AbstractFactory.Frameworks.Enums;
using AbstractFactory.Frameworks.Factories;

Render(new MaterialViewFactory());

void Render(IViewFactory factory)
{
    factory.CreateTextBox().Render();
    factory.CreateButton().Render();

}