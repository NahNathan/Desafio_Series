static SerieRepositorio repositorio = new SerieRepositorio();

private string static ()
{

    Console.WriteLine();
    Console.WriteLine("Series Pirateadas Grátis só 2.80 cada");
    Console.WriteLine("Qual opção deseja?");
    Console.WriteLine("1> Listar as séries");
    Console.WriteLine("2> Inserir uma nova série");
    Console.WriteLine("3> Atualizar série");
    Console.WriteLine("4> Vizualizar série");
    Console.WriteLine("5> Excluir série");
    Console.WriteLine("C> Limpar a tela");
    Console.WriteLine("X> Sair");
    Console.WriteLine("");

    string OpcaoUsuario = Console.ReadLine().ToUpper();
    while (OpcaoUsuario.ToUpper() != "x")
    {
        switch (OpcaoUsuario)
        {
            case "1":
                ListarSeries();
                break;

            case "2":
                InserirSerie();
                break;

            case "3":
                AtualizarSerie();
                break;

            case "4":
                ExcluirSerie();
                break;

            case "5":
                VizualizarSerie();
                break;
            
            case "C":
                Console.Clear();
                break;
            
            default:
                throw new ArgumentOutOfRangeExeption();
        }

        OpcaoUsuario= ObterOpcaousuario();
    }
    Console.WriteLine("Obrigado por utilizar nossos serviços, até logo! ");
    return OpcaoUsuario;
    }


private static void ListarSeries ()
{
    Console.WriteLine("Listar Séries");
    var lista = repositorio.Lista();
    if (lista.count==0){
        Console.WriteLine("Nenhuma série cadastrada");
        return;
    }
    foreach (var serie in lista)
    {
        var excluido = serie.RetornaExcluido();
        Console.WriteLine("#ID {0}: - {1} - {2}", serie.RetornaID(), serie.RetornaTitulo(), (excluido ? ">Excluído<": ""));
    }
}

private static void InserirSerie()
{
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    } //Mostrar todas as opções de gênero
    Console.WriteLine("Digite o gênero de acordo com as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o Título da série: ");
    string entradaTitulo = Console.ReadLine();

    Console.WriteLine("Digite o ano de estreia da série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descrição da série: ");
    string entradaDescricao = Console.ReadLine();

    Serie novaSerie = new Serie (ID: repositorio.ProximoID(),
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descrição: entradaDescricao);
    repositorio.Insere(novaSerie);
}

private static void AtualizarSerie()
{
    Console.WriteLine("Digite o ID da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.WriteLine("Digite o gênero das opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o título da série: ");
    string entradaTitulo = Console.ReadLine();

    Console.WriteLine("Digite o ano de estreia da série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descrição da série: ");
    string entradaDescricao = Console.ReadLine();

    Serie AtualizaSerie = new Serie (ID: indiceSerie,
                            genero: (Genero)entradaGenero,
                            titulo: entradaTitulo,
                            ano: entradaAno,
                            descrição: entradaDescricao);
    repositorio.Atualiza(indiceSerie, AtualizaSerie);
}

private static void ExcluirSerie()
{
    Console.WriteLine("Digite o ID da série: ");
    int indiceSerie= int.Parse(Console.ReadLine());
    Console.WriteLine("Tem Certeza que deseja excluir tal série? Ela será destruída para sempre (Muito tempo)");
    System.Console.WriteLine("Digite _n_ para não e _s_ para sim ");
    string resposta = Console.ReadLine();
    switch(resposta) {
        case "n":
            Console.WriteLine("Ta");
        break;
        case "s":
            repositorio.Exclui(indiceSerie);
        break;
        default:
        throw new ArgumentOutOfRangeExeption();
    }

}

private static void VizualizarSerie()
{
    System.Console.WriteLine("Digite o ID da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());
    var serie = repositorio.RetornaPorID(indiceSerie);
    Console.WriteLine(serie);
}

//Feito por Nathan Rodrigues
//Nenhum direito reservado