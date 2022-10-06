using System;
using static System.Console; 

string Dicionario = "";

WriteLine("DICIONÁRIO:");
WriteLine("");
WriteLine("1- Armário");
WriteLine("2- Bola");
WriteLine("3- Borracha");
WriteLine("4- Cadeira");
WriteLine("5- Cama");
WriteLine("6- Colar");
WriteLine("7- Escada");
WriteLine("8- Garfo");
WriteLine("9- Garrafa");
WriteLine("10- Lápis");
WriteLine("11- Livro");
WriteLine("12- Lixeira");
WriteLine("13- Lousa");
WriteLine("14- Mochila");
WriteLine("15- Mouse");
WriteLine("16- Óculos");
WriteLine("17- Porta");
WriteLine("18- Pulseira");
WriteLine("19- Tapete");
WriteLine("20- Vassoura");
Writeine("carteira");
WriteLine("Lápis");
WriteLine("");
WriteLine("Digite um destes números apresentados acima para saber o significado");
WriteLine("");
Dicionario = ReadLine();

switch (Dicionario)
{
    case  "1":
        WriteLine("Objeto selecionado: Armário");
        WriteLine("Móvel de madeira, metal ou outro material, dividido internamente por prateleiras ou gradis, para guardar roupas, louças etc.");
    break;

    case  "2":
        WriteLine("Objeto selecionado: Bola");
        WriteLine("Corpo Sólido completamente redondo em toda a sua extensão.");
    break;

    case  "3":
        WriteLine("Objeto selecionado: Borracha");
        WriteLine("Substância elástica e impermeável, resultante da coagulação do látex de vários vegetais, espécies de árvores do gênero Hevea e Ficus, com propriedades diversas e inúmeros usos industriais, segundo os vários tipos de tratamento a que é submetida.");
    break;

    case  "4":
        WriteLine("Objeto selecionado: Cadeira");
        WriteLine("Peça mobiliada composta de um assento individual e de um encosto, com ou sem braços.");
    break;

    case  "5":
        WriteLine("Objeto selecionado: Cama");
        WriteLine("Lugar onde se pode deitar e/ou dormir.");
    break;

    case  "6":
        WriteLine("Objeto selecionado: Colar");
        WriteLine("Ornato que se usa no pescoço e que é constituído por uma enfiada de pequenos objetos ou se apresenta em forma de cadeia.");
    break;

    case  "7":
        WriteLine("Objeto selecionado: Escada");
        WriteLine("Série de degraus, de materiais diversos, que conduz a lugares altos e baixos e por onde, andando, se pode subir ou descer.");
    break;

    case  "8":
        WriteLine("Objeto selecionado: Garfo");
        WriteLine("Utensílio de mesa, de três ou quatro dentes em uma das extremidades, usado para levar à boca alimentos sólidos ou segurar algum alimente a ser cortado.");
    break;

    case  "9":
        WriteLine("Objeto selecionado: Garrafa");
        WriteLine("Recipiente de gargalo e boca estreitos, geralmente de vidro, cristal ou louça e sem alça(s), destinado a conter líquida.");
    break;

    case  "10":
        WriteLine("Objeto selecionado: Lápis");
        WriteLine("Instrumento para escrever, desenhar ou riscar, que consiste geralmente em um estilete de grafita revestido de um invólucro de madeira.");
    break;

    case  "11":
        WriteLine("Objeto selecionado: Livro");
        WriteLine("Coleção de folhas de papel, impressas ou não, reunidas em cadernos cujos dorsos são unidos por meio de cola, costura etc., formando um volume que se recobre com capa resistente.");
    break;

    case  "12":
        WriteLine("Objeto selecionado: Lixeira");
        WriteLine("Lixeira ou caixote do lixo/balde do lixo é um repositório onde se armazena lixo temporariamente. É muito comum em centros urbanos onde os lixos jogados na rua podem causar a proliferação dos animais transmissores de doenças e onde se também entupir bueiros, causando enchentes.");
    break;

    case  "13":
        WriteLine("Objeto selecionado: Lousa");
        WriteLine("Lâmina de pedra extraída de xistos argilosos da variedade ardosifera.");
    break;

    case  "14":
        WriteLine("Objeto selecionado: Mochila");
        WriteLine("Saco de lona ou tecido sintético resistente que se leva às costas seguro por correias, usado por soldados, excursionistas, escolares, etc. Para transportar artigos de uso pessoal, provisões, material etc.");
    break;

    case  "15":
        WriteLine("Objeto selecionado: Mouse");
        WriteLine("O rato ou mouse é um periférico de entrada que, historicamente, se juntou ao teclado como auxiliar no processo de entrada de dados, especialmente em programas com interface gráfica. O rato, mouse tem, como função movimentar o cursor pelo ecrã ou tela do computador.");
    break;

    case  "16":
        WriteLine("Objeto selecionado: Óculos");
        WriteLine("Dispositivo usado para auxiliar, corrigir ou proteger a visão, que consiste em um par de lentes sustentadas em frente dos olhos por uma armação.");
    break;

    case  "17":
        WriteLine("Objeto selecionado: Porta");
        WriteLine("Abertura com o lado vertical mais comprido e a base ao nível do chão ou de um pavimento, que serve de entrada ou saída de um recinto.");
    break;

    case  "18":
        WriteLine("Objeto selecionado: Pulseira");
        WriteLine("Joia ou adorno para os pulsos ou braços; bracelete.");
    break;

    case  "19":
        WriteLine("Objeto selecionado: Tapete");
        WriteLine("Fazenda geralmente encorpada, tecida ou bordada, usada para revestir e/ou adornar pisos.");
    break;

    case  "20":
        WriteLine("Objeto selecionado: Vassoura");
        WriteLine("Utensilio para varrer, constituído por um cabo longo de madeira a que se fixa, numa das extremidades, um feixe de fibras de piaçaba ou outras fibras ou pelos naturais ou sintéticos.");
    break;
        
    default:
    WriteLine("Objeto inválido");
    break;
}
WriteLine("");
