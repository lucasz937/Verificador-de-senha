

Console.WriteLine("digite nome de usuário: ") ; 
string usuarioCadastrado = Console.ReadLine();
Console.WriteLine("digite sua senha: ") ; 
string senhaCadastrada = Console.ReadLine();
Console.WriteLine("Cadastro Concluído !");

Console.WriteLine("Para fazer login digite seu nome de usuário anteriormente cadastrado: ");
string user = Console.ReadLine();

 if (user != usuarioCadastrado) 
 {
    while ( user != usuarioCadastrado )
    {
        Console.WriteLine("Usuario não cadastrado, digite novamente : ") ;
        user = Console.ReadLine();
    }
 }
 Console.WriteLine("Digite sua senha: ");
 string senha = Console.ReadLine();
 if (senha != senhaCadastrada) 
 {
    while ( senha != senhaCadastrada )
    {
        Console.WriteLine("Senha incorreta, digite novamente : ") ;
        senha = Console.ReadLine();
    }
    Console.WriteLine("Logado com sucesso! ");
 } 