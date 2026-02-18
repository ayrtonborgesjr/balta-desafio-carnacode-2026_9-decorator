using CafeteriaDecorator.Console.Bebidas;

namespace CafeteriaDecorator.Tests;

public class BebidasTests
{
    [Fact]
    public void Espresso_DeveRetornarCustoCorreto()
    {
        // Arrange
        var espresso = new Espresso();

        // Act
        var custo = espresso.GetCost();

        // Assert
        Assert.Equal(3.50m, custo);
    }

    [Fact]
    public void Espresso_DeveRetornarDescricaoCorreta()
    {
        // Arrange
        var espresso = new Espresso();

        // Act
        var descricao = espresso.GetDescription();

        // Assert
        Assert.Equal("Espresso", descricao);
    }

    [Fact]
    public void Cappuccino_DeveRetornarCustoCorreto()
    {
        // Arrange
        var cappuccino = new Cappuccino();

        // Act
        var custo = cappuccino.GetCost();

        // Assert
        Assert.Equal(4.50m, custo);
    }

    [Fact]
    public void Cappuccino_DeveRetornarDescricaoCorreta()
    {
        // Arrange
        var cappuccino = new Cappuccino();

        // Act
        var descricao = cappuccino.GetDescription();

        // Assert
        Assert.Equal("Cappuccino", descricao);
    }
}

