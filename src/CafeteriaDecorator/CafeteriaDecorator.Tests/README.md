# Testes Unitários - CafeteriaDecorator

Este projeto contém testes unitários completos para a implementação do padrão Decorator na aplicação de Cafeteria.

## 📊 Resumo dos Testes

**Total de Testes:** 33  
**Status:** ✅ Todos passando  
**Framework:** xUnit  
**Cobertura:** Cobertura de código disponível via coverlet.collector

## 🧪 Estrutura dos Testes

### 1. BebidasTests.cs
Testa as classes base de bebidas (Espresso e Cappuccino):
- ✅ Espresso retorna custo correto (R$ 3.50)
- ✅ Espresso retorna descrição correta
- ✅ Cappuccino retorna custo correto (R$ 4.50)
- ✅ Cappuccino retorna descrição correta

**Total:** 4 testes

### 2. DecoratorsTests.cs
Testa cada decorator individualmente:
- ✅ LeiteDecorator adiciona R$ 0.50 e " com Leite"
- ✅ ChocolateDecorator adiciona R$ 0.70 e " com Chocolate"
- ✅ ChantillyDecorator adiciona R$ 1.00 e " com Chantilly"
- ✅ CarameloDecorator adiciona R$ 0.80 e " com Caramelo"

**Total:** 8 testes (custo e descrição para cada decorator)

### 3. DecoratorCombinationsTests.cs
Testa combinações de múltiplos decorators:
- ✅ Espresso com Leite e Chocolate
- ✅ Cappuccino com Chocolate, Chantilly e Caramelo
- ✅ Espresso com todos os decorators
- ✅ Decoradores em diferentes ordens
- ✅ Validação de que a ordem afeta a descrição mas não o custo

**Total:** 11 testes

### 4. EdgeCasesTests.cs
Testa casos extremos e validações adicionais:
- ✅ Bebidas simples mantêm valores originais
- ✅ Múltiplos decorators do mesmo tipo acumulam valores
- ✅ Tipos são corretamente preservados
- ✅ Custos são sempre positivos
- ✅ Descrições nunca são vazias
- ✅ Chantilly é o decorator mais caro
- ✅ Precisão decimal mantida em 2 casas
- ✅ Diferenças proporcionais entre bebidas

**Total:** 10 testes

## 🚀 Como Executar os Testes

### Executar todos os testes
```powershell
dotnet test
```

### Executar com verbosidade
```powershell
dotnet test --verbosity normal
```

### Executar com cobertura de código
```powershell
dotnet test --collect:"XPlat Code Coverage"
```

### Executar testes específicos
```powershell
dotnet test --filter "ClassName=BebidasTests"
dotnet test --filter "ClassName=DecoratorsTests"
dotnet test --filter "ClassName=DecoratorCombinationsTests"
dotnet test --filter "ClassName=EdgeCasesTests"
```

## 📋 Tabela de Preços

| Item | Custo Adicional |
|------|----------------|
| Espresso (base) | R$ 3.50 |
| Cappuccino (base) | R$ 4.50 |
| Leite | + R$ 0.50 |
| Chocolate | + R$ 0.70 |
| Caramelo | + R$ 0.80 |
| Chantilly | + R$ 1.00 |

## ✅ Cenários de Teste Cobertos

1. **Bebidas Base**: Validação de custos e descrições básicas
2. **Decorators Simples**: Cada decorator aplicado individualmente
3. **Decorators Múltiplos**: Combinações de 2 ou mais decorators
4. **Decorators Aninhados**: Até 5 níveis de decoração
5. **Ordem de Decoração**: Validação de que ordem afeta descrição
6. **Acumulação de Custos**: Soma correta de todos os decorators
7. **Tipos e Herança**: Validação da hierarquia de tipos
8. **Edge Cases**: Valores positivos, descrições não vazias, etc.

## 🎯 Padrão Decorator

Os testes validam a correta implementação do padrão Decorator:
- **Componente**: `Bebida` (classe abstrata)
- **Componentes Concretos**: `Espresso`, `Cappuccino`
- **Decorator**: `BebidaDecorator` (classe abstrata)
- **Decorators Concretos**: `LeiteDecorator`, `ChocolateDecorator`, `ChantillyDecorator`, `CarameloDecorator`

## 📦 Dependências

```xml
<PackageReference Include="coverlet.collector" Version="6.0.2"/>
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.12.0"/>
<PackageReference Include="xunit" Version="2.9.2"/>
<PackageReference Include="xunit.runner.visualstudio" Version="2.8.2"/>
```

## 🏆 Qualidade do Código

- ✅ 100% dos testes passando
- ✅ Cobertura abrangente de cenários
- ✅ Testes bem organizados e nomeados
- ✅ Padrão AAA (Arrange-Act-Assert) seguido
- ✅ Testes isolados e independentes
- ✅ Validação de comportamento e estado

