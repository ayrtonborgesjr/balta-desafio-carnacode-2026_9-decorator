using CafeteriaDecorator.Console.Bebidas;
using CafeteriaDecorator.Console.Decorators;

namespace CafeteriaDecorator.Tests;

public class EdgeCasesTests
{
    [Fact]
    public void Espresso_BebidaSimples_MantemValoresOriginais()
    {
        // Arrange
        var bebida = new Espresso();

        // Act & Assert
        Assert.Equal(3.50m, bebida.GetCost());
        Assert.Equal("Espresso", bebida.GetDescription());
    }

    [Fact]
    public void Cappuccino_BebidaSimples_MantemValoresOriginais()
    {
        // Arrange
        var bebida = new Cappuccino();

        // Act & Assert
        Assert.Equal(4.50m, bebida.GetCost());
        Assert.Equal("Cappuccino", bebida.GetDescription());
    }

    [Fact]
    public void MultiplosMesmosDecorators_DevemAcumularValores()
    {
        // Arrange
        var bebida = new LeiteDecorator(
            new LeiteDecorator(
                new LeiteDecorator(
                    new Espresso())));

        // Act
        var custo = bebida.GetCost();
        var descricao = bebida.GetDescription();

        // Assert
        Assert.Equal(5.00m, custo); // 3.50 + 0.50 + 0.50 + 0.50
        Assert.Equal("Espresso com Leite com Leite com Leite", descricao);
    }

    [Fact]
    public void DecoratorUnico_DeveManterTipoBebida()
    {
        // Arrange
        Bebida bebida = new LeiteDecorator(new Espresso());

        // Act & Assert
        Assert.IsType<LeiteDecorator>(bebida);
        Assert.IsAssignableFrom<Bebida>(bebida);
    }

    [Fact]
    public void DecoratorAninhado_DeveManterTipoBebida()
    {
        // Arrange
        Bebida bebida = new ChocolateDecorator(
            new LeiteDecorator(
                new Espresso()));

        // Act & Assert
        Assert.IsType<ChocolateDecorator>(bebida);
        Assert.IsAssignableFrom<Bebida>(bebida);
        Assert.IsAssignableFrom<BebidaDecorator>(bebida);
    }

    [Fact]
    public void CustoZeroNaoDeveOcorrer_SemprePositivo()
    {
        // Arrange
        var bebidas = new Bebida[]
        {
            new Espresso(),
            new Cappuccino(),
            new LeiteDecorator(new Espresso()),
            new ChocolateDecorator(new Cappuccino())
        };

        // Act & Assert
        foreach (var bebida in bebidas)
        {
            Assert.True(bebida.GetCost() > 0, $"Custo deve ser positivo para {bebida.GetDescription()}");
        }
    }

    [Fact]
    public void DescricaoNaoDeveSerVazia()
    {
        // Arrange
        var bebidas = new Bebida[]
        {
            new Espresso(),
            new Cappuccino(),
            new LeiteDecorator(new Espresso()),
            new ChocolateDecorator(new Cappuccino()),
            new CarameloDecorator(new ChantillyDecorator(new Espresso()))
        };

        // Act & Assert
        foreach (var bebida in bebidas)
        {
            Assert.False(string.IsNullOrWhiteSpace(bebida.GetDescription()), 
                "Descrição não deve ser vazia ou conter apenas espaços");
        }
    }

    [Fact]
    public void DecoratorComChantilly_DeveAdicionarMaiorValor()
    {
        // Arrange
        var bebidaBase = new Espresso();
        var comLeite = new LeiteDecorator(bebidaBase);
        var comChocolate = new ChocolateDecorator(bebidaBase);
        var comCaramelo = new CarameloDecorator(bebidaBase);
        var comChantilly = new ChantillyDecorator(bebidaBase);

        // Act
        var custosAdicionais = new[]
        {
            comLeite.GetCost() - bebidaBase.GetCost(),
            comChocolate.GetCost() - bebidaBase.GetCost(),
            comCaramelo.GetCost() - bebidaBase.GetCost(),
            comChantilly.GetCost() - bebidaBase.GetCost()
        };

        // Assert
        var custoChantilly = comChantilly.GetCost() - bebidaBase.GetCost();
        Assert.Equal(1.00m, custoChantilly);
        Assert.True(custoChantilly == custosAdicionais.Max(), 
            "Chantilly deve ser o decorator mais caro");
    }

    [Fact]
    public void PrecisaoDecimal_DeveManter2CasasDecimais()
    {
        // Arrange
        var bebida = new CarameloDecorator(
            new ChantillyDecorator(
                new ChocolateDecorator(
                    new LeiteDecorator(
                        new Espresso()))));

        // Act
        var custo = bebida.GetCost();
        var custoArredondado = Math.Round(custo, 2);

        // Assert
        Assert.Equal(custoArredondado, custo);
    }

    [Fact]
    public void BebidasDiferentes_ComMesmosDecorators_DevemTerDiferencaProporcional()
    {
        // Arrange
        var espressoComLeite = new LeiteDecorator(new Espresso());
        var cappuccinoComLeite = new LeiteDecorator(new Cappuccino());

        // Act
        var diferencaBase = new Cappuccino().GetCost() - new Espresso().GetCost();
        var diferencaDecorada = cappuccinoComLeite.GetCost() - espressoComLeite.GetCost();

        // Assert
        Assert.Equal(diferencaBase, diferencaDecorada);
    }
}

