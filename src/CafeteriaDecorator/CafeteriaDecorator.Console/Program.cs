using CafeteriaDecorator.Console.Bebidas;
using CafeteriaDecorator.Console.Decorators;

Console.WriteLine("=== Cafeteria com Decorator ===\n");

Bebida pedido1 = new Espresso();
Console.WriteLine($"{pedido1.GetDescription()} - R$ {pedido1.GetCost():N2}");

Bebida pedido2 =
    new ChocolateDecorator(
        new LeiteDecorator(
            new Espresso()));

Console.WriteLine($"{pedido2.GetDescription()} - R$ {pedido2.GetCost():N2}");

Bebida pedido3 =
    new CarameloDecorator(
        new ChantillyDecorator(
            new ChocolateDecorator(
                new Cappuccino())));

Console.WriteLine($"{pedido3.GetDescription()} - R$ {pedido3.GetCost():N2}");