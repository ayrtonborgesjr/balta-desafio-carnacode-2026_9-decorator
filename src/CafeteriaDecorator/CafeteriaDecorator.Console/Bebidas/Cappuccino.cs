namespace CafeteriaDecorator.Console.Bebidas;

public class Cappuccino : Bebida
{
    public override decimal GetCost() => 4.50m;
    public override string GetDescription() => "Cappuccino";
}