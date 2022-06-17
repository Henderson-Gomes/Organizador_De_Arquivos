using ManipulcaoDeArquivo;

LocalizarArquivo localizar = new LocalizarArquivo();

localizar.VarreArquivo();
Console.WriteLine("--- PASTAS ---");
Console.WriteLine(localizar.LocalVideo);
Console.WriteLine(localizar.LocalImagem) ;
Console.WriteLine(localizar.LocalMusica);
Console.WriteLine(localizar.LocalDocumento);
Console.WriteLine(localizar.LocalDesktop);
Console.WriteLine(localizar.LocalDownload);



























/*
const string filePathOrigem = @"C:\Users\hende\OneDrive\Imagens\ovelho.png";
const string filePathDestino = @"C:\Users\hende\OneDrive\Imagens\Saved Pictures\resoaning.png";
const string arquivoAcessado = @"C:\Users\hende\OneDrive\Documentos\texto.txt";
File.Exists(filePathOrigem);

var attrs = File.GetAttributes(arquivoAcessado);

if ((attrs & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
    Console.WriteLine("read-only");

if ((attrs & FileAttributes.Compressed) == FileAttributes.Compressed)
    Console.WriteLine("compressed");
*/

/*
Console.WriteLine("Amor , me avise se vc ve essa mensagem !!!!");
Console.ReadLine();
Console.ReadLine();
string DiscoLocal = @"C:\Users";

string[] localItens = Directory.GetDirectories(DiscoLocal);

string pastaUser = "";
foreach (string itensItem in localItens)
{
    if (itensItem.Contains("All Users") || itensItem.Contains("Default") || itensItem.Contains("Public") || itensItem.Contains("Todos os Usuário Padrão") || itensItem.Contains("Usuário Padrão") || itensItem.Contains("Todos os Usuário"))
    {

    }
    else
    {
        pastaUser = itensItem;
       
    }
}
string pastaDonwload = pastaUser;
localItens = Directory.GetDirectories(pastaUser);
foreach (string item in localItens)
{
    if (item.Contains("Downloads"))
    {
        pastaDonwload = item;

    }
}
localItens = Directory.GetFiles(pastaDonwload);

Console.WriteLine();
Console.WriteLine(pastaDonwload);
foreach (string item in localItens)
{
    Console.WriteLine(item);
}
Imagem(pastaDonwload,pastaUser);
Console.ReadLine();
/*
string[] arquivos = Directory.GetFiles(@"C:\Users\hende\OneDrive\Área de Trabalho\Pasta Teste");
List<String> Imagens = new List<String>();
foreach (string item in arquivos)
{
    int Localvalor = item.IndexOf(".jpg");
    if (item.Contains(".jpg")|| item.Contains(".jpeg")||item.Contains(".png"))
    {
        Imagens.Add(item);
    };

}

string folderName = @"C:\Users\hende\OneDrive\Área de Trabalho\Pasta Teste";
string pastaImagens = @"C:\Users\hende\OneDrive\Área de Trabalho\Pasta Teste\Imagens";
// To create a string that specifies the path to a subfolder under your
// top-level folder, add a name for the subfolder to folderName.
string pathString = System.IO.Path.Combine(folderName, "Imagens");
System.IO.Directory.CreateDirectory(pathString);


foreach (string item in Imagens)
{
    
    int index = item.IndexOf(@"Pasta Teste\" ) + 11;
    int tamanho = item.Length - index;
     Console.WriteLine(index);
    Console.WriteLine(tamanho);
    string nomeArquivo = item.Substring(index, tamanho);
    Console.WriteLine(nomeArquivo);
    File.Move(item, pastaImagens + nomeArquivo, true);
    
}


foreach (String item in Imagens)
{
    Console.WriteLine(item);
}




*/
/*
void Imagem(string pasta,string pastaUser)
{
    string[] arquivos = Directory.GetFiles(pasta);
    List<String> Imagens = new List<String>();
    
        foreach (string item in Imagens)
        {

            int index = item.IndexOf(@"Downloads") + 10;
            int tamanho = item.Length - index;

            string nomeArquivo = item.Substring(index, tamanho);

            try
            {
                File.Move(item, @"C:\Users\hende\OneDrive\Imagens\" + nomeArquivo, true);
            }
            catch
            {
                Console.WriteLine("Erro");
            }


        }
    
    

    foreach (string item in arquivos)
    {
        if (item.Contains(".jpg") || item.Contains(".jpeg") || item.Contains(".png"))
        {
            Imagens.Add(item);
        };

    }

    foreach (string item in Imagens)
    {

        int index = item.IndexOf(@"Downloads") + 10;
        int tamanho = item.Length - index;

        string nomeArquivo = item.Substring(index, tamanho);

        if (Directory.Exists(pastaUser+@"Imagens\"))
        {
            try
            {
                File.Move(item, pastaUser + @"Imagens\" + nomeArquivo, true);
            }
            catch
            {
                Console.WriteLine("Erro");
            }
        }
        else if (Directory.Exists(pastaUser+@"OneDrive\Imagens\"))
        {
            try
            {
                File.Move(item, pastaUser + @"OneDrive\Imagens\" + nomeArquivo, true);
            }
            catch
            {
                Console.WriteLine("Erro");
            }
        }


    }
}
void Documentos(string pasta)
{

}
*/