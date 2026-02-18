using CafeteriaDecorator.Console.Bebidas;

namespace CafeteriaDecorator.Console.Decorators;

public abstract class BebidaDecorator : Bebida
{
    protected Bebida _bebida;

    protected BebidaDecorator(Bebida bebida)
    {
        _bebida = bebida;
    }
}