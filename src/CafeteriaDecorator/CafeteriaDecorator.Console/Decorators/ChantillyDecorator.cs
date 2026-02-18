using CafeteriaDecorator.Console.Bebidas;

namespace CafeteriaDecorator.Console.Decorators;

public class ChantillyDecorator : BebidaDecorator
{
    public ChantillyDecorator(Bebida bebida) : base(bebida) { }

    public override decimal GetCost() => _bebida.GetCost() + 1.00m;

    public override string GetDescription() =>
        _bebida.GetDescription() + " com Chantilly";
}