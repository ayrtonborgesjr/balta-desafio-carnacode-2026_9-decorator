using CafeteriaDecorator.Console.Bebidas;

namespace CafeteriaDecorator.Console.Decorators;

public class CarameloDecorator : BebidaDecorator
{
    public CarameloDecorator(Bebida bebida) : base(bebida) { }

    public override decimal GetCost() => _bebida.GetCost() + 0.80m;

    public override string GetDescription() =>
        _bebida.GetDescription() + " com Caramelo";
}