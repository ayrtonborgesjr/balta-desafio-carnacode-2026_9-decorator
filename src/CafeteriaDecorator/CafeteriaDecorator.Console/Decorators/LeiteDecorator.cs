using CafeteriaDecorator.Console.Bebidas;

namespace CafeteriaDecorator.Console.Decorators;

public class LeiteDecorator : BebidaDecorator
{
    public LeiteDecorator(Bebida bebida) : base(bebida) { }

    public override decimal GetCost() => _bebida.GetCost() + 0.50m;

    public override string GetDescription() =>
        _bebida.GetDescription() + " com Leite";
}