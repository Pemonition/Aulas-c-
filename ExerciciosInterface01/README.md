# Exercícios de Interface (Aula POO 07)

Resolução dos 9 exercícios de interfaces em C#, baseados no PDF "Exercícios Interface 01".

Cada exercício é um projeto de console independente (`net10.0`):

| Pasta | Exercício | Interface principal |
|---|---|---|
| `Exercicio1_Animais` | 1 - Animais | `IAnimal` |
| `Exercicio2_FormasGeometricas` | 2 - Formas Geométricas | `IFormaGeometrica` |
| `Exercicio3_ReprodutorMultimidia` | 3 - Reprodutor Multimídia | `IReprodutorMultimidia` |
| `Exercicio4_ProcessadorPagamento` | 4 - Processador de Pagamento | `IProcessadorPagamento` |
| `Exercicio5_Transporte` | 5 - Transporte | `ITransporte` |
| `Exercicio6_Notificador` | 6 - Notificações de eventos | `INotificador` |
| `Exercicio7_Fretes` | 7 - Cálculo Flexível de Fretes | `IFretavel` |
| `Exercicio8_RPG` | 8 - Habilidades de RPG | `IAtacante`, `ICurador`, `IVoador` |
| `Exercicio9_GeradorRelatorios` | 9 - Gerador de Relatórios Desacoplado | `IFonteDeDados`, `IExportadorRelatorio` |

## Como rodar cada exercício

```bash
cd ExerciciosInterface01/Exercicio1_Animais
dotnet run
```

Repita trocando a pasta pelo exercício desejado, ou abra `ExerciciosInterface01.sln` na sua IDE (Visual Studio / Rider) e execute o projeto desejado como projeto de inicialização.
