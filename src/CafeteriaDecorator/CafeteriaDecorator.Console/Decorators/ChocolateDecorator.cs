using CafeteriaDecorator.Console.Bebidas;

namespace CafeteriaDecorator.Console.Decorators;

public class ChocolateDecorator : BebidaDecorator
{
    public ChocolateDecorator(Bebida bebida) : base(bebida) { }

    public override decimal GetCost() => _bebida.GetCost() + 0.70m;

    public override string GetDescription() =>
        _bebida.GetDescription() + " com Chocolate";
}