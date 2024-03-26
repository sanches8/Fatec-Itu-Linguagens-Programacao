string mes;
Console.WriteLine("Digite um mês do ano (Janeiro; Fevereiro, Março, etc): ");
mes = Console.ReadLine();

switch (mes)
{
    case "Janeiro":
    case "Março":
    case "Maio":
    case "Julho":
    case "Agosto":
    case "Outubro":
    case "Dezembro":
        Console.WriteLine("Este mês tem 31 dias.");
        break;
    case "Abril":
    case "Junho":
    case "Setembro":
    case "Novembro":
        Console.WriteLine("Este mês tem 30 dias.");
        break;
    case "Fevereiro":
        Console.WriteLine("Este mês tem 28 dias ou 29, se o ano for bissexto.");
        break;
    default:
        Console.WriteLine("Nome de mês inválido.");
        break;
}
         