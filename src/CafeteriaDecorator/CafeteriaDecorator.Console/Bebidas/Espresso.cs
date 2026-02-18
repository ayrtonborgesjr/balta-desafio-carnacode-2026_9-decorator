namespace CafeteriaDecorator.Console.Bebidas;

public class Espresso : Bebida
{
    public override decimal GetCost() => 3.50m;
    public override string GetDescription() => "Espresso";
}