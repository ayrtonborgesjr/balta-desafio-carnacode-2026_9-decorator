using CafeteriaDecorator.Console.Bebidas;
using CafeteriaDecorator.Console.Decorators;

namespace CafeteriaDecorator.Tests;

public class DecoratorCombinationsTests
{
    [Fact]
    public void EspressoComLeiteEChocolate_DeveRetornarCustoCorreto()
    {
        // Arrange
        var bebida = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        // Act
        var custo = bebida.GetCost();

        // Assert
        Assert.Equal(4.70m, custo); // 3.50 + 0.50 + 0.70
    }

    [Fact]
    public void EspressoComLeiteEChocolate_DeveRetornarDescricaoCorreta()
    {
        // Arrange
        var bebida = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        // Act
        var descricao = bebida.GetDescription();

        // Assert
        Assert.Equal("Espresso com Leite com Chocolate", descricao);
    }

    [Fact]
    public void CappuccinoComChocolateChantillyECaramelo_DeveRetornarCustoCorreto()
    {
        // Arrange
        var bebida = new CarameloDecorator(
            new ChantillyDecorator(
                new ChocolateDecorator(
                    new Cappuccino())));

        // Act
        var custo = bebida.GetCost();

        // Assert
        Assert.Equal(7.00m, custo); // 4.50 + 0.70 + 1.00 + 0.80
    }

    [Fact]
    public void CappuccinoComChocolateChantillyECaramelo_DeveRetornarDescricaoCorreta()
    {
        // Arrange
        var bebida = new CarameloDecorator(
            new ChantillyDecorator(
                new ChocolateDecorator(
                    new Cappuccino())));

        // Act
        var descricao = bebida.GetDescription();

        // Assert
        Assert.Equal("Cappuccino com Chocolate com Chantilly com Caramelo", descricao);
    }

    [Fact]
    public void EspressoComTodosOsDecorators_DeveRetornarCustoCorreto()
    {
        // Arrange
        var bebida = new CarameloDecorator(
            new ChantillyDecorator(
                new ChocolateDecorator(
                    new LeiteDecorator(
                        new Espresso()))));

        // Act
        var custo = bebida.GetCost();

        // Assert
        Assert.Equal(6.50m, custo); // 3.50 + 0.50 + 0.70 + 1.00 + 0.80
    }

    [Fact]
    public void EspressoComTodosOsDecorators_DeveRetornarDescricaoCorreta()
    {
        // Arrange
        var bebida = new CarameloDecorator(
            new ChantillyDecorator(
                new ChocolateDecorator(
                    new LeiteDecorator(
                        new Espresso()))));

        // Act
        var descricao = bebida.GetDescription();

        // Assert
        Assert.Equal("Espresso com Leite com Chocolate com Chantilly com Caramelo", descricao);
    }

    [Fact]
    public void CappuccinoComLeite_DeveRetornarCustoCorreto()
    {
        // Arrange
        var bebida = new LeiteDecorator(new Cappuccino());

        // Act
        var custo = bebida.GetCost();

        // Assert
        Assert.Equal(5.00m, custo); // 4.50 + 0.50
    }

    [Fact]
    public void CappuccinoComLeite_DeveRetornarDescricaoCorreta()
    {
        // Arrange
        var bebida = new LeiteDecorator(new Cappuccino());

        // Act
        var descricao = bebida.GetDescription();

        // Assert
        Assert.Equal("Cappuccino com Leite", descricao);
    }

    [Fact]
    public void DecoratoresMultiplosNaMesmaOrdem_DevemRetornarMesmoResultado()
    {
        // Arrange
        var bebida1 = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        var bebida2 = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        // Act & Assert
        Assert.Equal(bebida1.GetCost(), bebida2.GetCost());
        Assert.Equal(bebida1.GetDescription(), bebida2.GetDescription());
    }

    [Fact]
    public void DecoratoresEmOrdemDiferente_DevemRetornarCustoIgual()
    {
        // Arrange
        var bebida1 = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        var bebida2 = new LeiteDecorator(
            new ChocolateDecorator(
                new Espresso()));

        // Act & Assert
        Assert.Equal(bebida1.GetCost(), bebida2.GetCost());
    }

    [Fact]
    public void DecoratoresEmOrdemDiferente_DevemRetornarDescricaoDiferente()
    {
        // Arrange
        var bebida1 = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        var bebida2 = new LeiteDecorator(
            new ChocolateDecorator(
                new Espresso()));

        // Act
        var descricao1 = bebida1.GetDescription();
        var descricao2 = bebida2.GetDescription();

        // Assert
        Assert.NotEqual(descricao1, descricao2);
        Assert.Equal("Espresso com Leite com Chocolate", descricao1);
        Assert.Equal("Espresso com Chocolate com Leite", descricao2);
    }
}

