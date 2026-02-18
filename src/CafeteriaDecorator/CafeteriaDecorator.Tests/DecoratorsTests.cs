using CafeteriaDecorator.Console.Bebidas;
using CafeteriaDecorator.Console.Decorators;

namespace CafeteriaDecorator.Tests;

public class DecoratorsTests
{
    [Fact]
    public void LeiteDecorator_DeveAdicionarCustoCorreto()
    {
        // Arrange
        var bebida = new Espresso();
        var bebidaComLeite = new LeiteDecorator(bebida);

        // Act
        var custo = bebidaComLeite.GetCost();

        // Assert
        Assert.Equal(4.00m, custo); // 3.50 + 0.50
    }

    [Fact]
    public void LeiteDecorator_DeveAdicionarDescricaoCorreta()
    {
        // Arrange
        var bebida = new Espresso();
        var bebidaComLeite = new LeiteDecorator(bebida);

        // Act
        var descricao = bebidaComLeite.GetDescription();

        // Assert
        Assert.Equal("Espresso com Leite", descricao);
    }

    [Fact]
    public void ChocolateDecorator_DeveAdicionarCustoCorreto()
    {
        // Arrange
        var bebida = new Espresso();
        var bebidaComChocolate = new ChocolateDecorator(bebida);

        // Act
        var custo = bebidaComChocolate.GetCost();

        // Assert
        Assert.Equal(4.20m, custo); // 3.50 + 0.70
    }

    [Fact]
    public void ChocolateDecorator_DeveAdicionarDescricaoCorreta()
    {
        // Arrange
        var bebida = new Espresso();
        var bebidaComChocolate = new ChocolateDecorator(bebida);

        // Act
        var descricao = bebidaComChocolate.GetDescription();

        // Assert
        Assert.Equal("Espresso com Chocolate", descricao);
    }

    [Fact]
    public void ChantillyDecorator_DeveAdicionarCustoCorreto()
    {
        // Arrange
        var bebida = new Cappuccino();
        var bebidaComChantilly = new ChantillyDecorator(bebida);

        // Act
        var custo = bebidaComChantilly.GetCost();

        // Assert
        Assert.Equal(5.50m, custo); // 4.50 + 1.00
    }

    [Fact]
    public void ChantillyDecorator_DeveAdicionarDescricaoCorreta()
    {
        // Arrange
        var bebida = new Cappuccino();
        var bebidaComChantilly = new ChantillyDecorator(bebida);

        // Act
        var descricao = bebidaComChantilly.GetDescription();

        // Assert
        Assert.Equal("Cappuccino com Chantilly", descricao);
    }

    [Fact]
    public void CarameloDecorator_DeveAdicionarCustoCorreto()
    {
        // Arrange
        var bebida = new Cappuccino();
        var bebidaComCaramelo = new CarameloDecorator(bebida);

        // Act
        var custo = bebidaComCaramelo.GetCost();

        // Assert
        Assert.Equal(5.30m, custo); // 4.50 + 0.80
    }

    [Fact]
    public void CarameloDecorator_DeveAdicionarDescricaoCorreta()
    {
        // Arrange
        var bebida = new Cappuccino();
        var bebidaComCaramelo = new CarameloDecorator(bebida);

        // Act
        var descricao = bebidaComCaramelo.GetDescription();

        // Assert
        Assert.Equal("Cappuccino com Caramelo", descricao);
    }
}

