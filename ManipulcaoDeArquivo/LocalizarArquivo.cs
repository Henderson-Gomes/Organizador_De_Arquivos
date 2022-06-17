using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulcaoDeArquivo
{
    internal class LocalizarArquivo
    {
        public string DiscoLocal { get; set; }
        public string LocalImagem { get; set; }
        public string LocalDocumento { get; set; }
        public string LocalVideo { get; set; }
        public string LocalMusica { get; set; }
        public string LocalDownload { get; set; }
        public string LocalDesktop { get; set; }
        public List<string> ListaImagem { get; set; } = new List<string>();
        public List<string> ListaDocumento { get; set; } = new List<string>();
        public List<string> ListaVideo { get; set; } = new List<string>();
        public List<string> ListaMusica { get; set; } = new List<string>();

        public LocalizarArquivo()
        {
            DiscoLocal = @"C:\Users";
            string[] listaPasta = Directory.GetDirectories(DiscoLocal);
            foreach (string itensItem in listaPasta)
            {
                if (itensItem.Contains("All Users") || itensItem.Contains("Default") || itensItem.Contains("Public") || itensItem.Contains("Todos os Usuário Padrão") || itensItem.Contains("Usuário Padrão") || itensItem.Contains("Todos os Usuário"))
                {

                }
                else
                {
                    DiscoLocal = itensItem;

                }

            }
            foreach (string Item in Directory.GetDirectories(DiscoLocal))
            {
                if (Item.Contains("Imagens"))
                {
                    LocalImagem = Item;
                }
                else if (Item.Contains("Documentos"))
                {
                    LocalDocumento = Item;
                }
                else if (Item.Contains("Music"))
                {
                    LocalMusica = Item;
                }
                else if (Item.Contains("Videos"))
                {
                    LocalVideo = Item;
                }
                else if (Item.Contains("Downloads"))
                {
                    LocalDownload = Item;
                }
                else if (Item.Contains("Área de Trabalho"))
                {
                    LocalDesktop = Item;
                }
            }
            foreach (string Item in Directory.GetDirectories(DiscoLocal + @"\OneDrive"))
            {
                if (Item.Contains("Imagens"))
                {
                    LocalImagem = Item;
                }
                else if (Item.Contains("Documentos"))
                {
                    LocalDocumento = Item;
                }
                else if (Item.Contains("Music"))
                {
                    LocalMusica = Item;
                }
                else if (Item.Contains("Vídeos"))
                {
                    LocalVideo = Item;
                }
                else if (Item.Contains("Downloads"))
                {
                    LocalDownload = Item;
                }
                else if (Item.Contains("Área de Trabalho"))
                {
                    LocalDesktop = Item;
                }


            }


        }

        public void VarreArquivo()
        {
            string[] arquivo;
            
            
            arquivo = Directory.GetFiles(LocalDownload);
            SepararArquivo(arquivo);
            arquivo = Directory.GetFiles(LocalDesktop);
            SepararArquivo(arquivo);
            arquivo = Directory.GetFiles(LocalDocumento);
            SepararArquivo(arquivo);
            arquivo = Directory.GetFiles(LocalImagem);
            SepararArquivo(arquivo);
            arquivo = Directory.GetFiles(LocalMusica);
            SepararArquivo(arquivo);
            arquivo = Directory.GetFiles(LocalVideo);
            SepararArquivo(arquivo);

        }


        public void SepararArquivo(string[] arquivo)
        {
            foreach (string item in arquivo)
            {

                if (item.Contains(".jpg") || item.Contains(".jpeg") || item.Contains(".png") || item.Contains(".gif") ||
                    item.Contains(".bmp") || item.Contains(".tiff") || item.Contains(".exif") || item.Contains(".svg") || item.Contains(".webp"))
                {
                    ListaImagem.Add(item);

                }
                else if (item.Contains(".pdf") || item.Contains(".odt") || item.Contains(".doc") || item.Contains(".docx") ||
                    item.Contains(".docm") || item.Contains(".dot") || item.Contains(".dotm") || item.Contains(".dotx") ||
                    item.Contains(".html") || item.Contains(".htm") || item.Contains(".odt") || item.Contains(".rtf") ||
                    item.Contains(".txt") || item.Contains(".wps") || item.Contains(".xml") || item.Contains(".xps") ||
                    item.Contains(".xlsx") || item.Contains(".xlsm") || item.Contains(".xlsb") || item.Contains(".xltx"))
                {
                    ListaDocumento.Add(item);
                }
                else if (item.Contains(".aac") || item.Contains(".mp3") || item.Contains(".wma") ||
                    item.Contains(".alac") || item.Contains(".flac") || item.Contains(".wma") || item.Contains(".aiff") ||
                    item.Contains(".pcm") || item.Contains(".wav"))
                {
                    ListaMusica.Add(item);
                }
                else if (item.Contains(".mkv") || item.Contains(".mp4") || item.Contains(".wmv") || item.Contains(".avi") ||
                    item.Contains(".flv") || item.Contains(".ogg") || item.Contains(".avchd") || item.Contains(".mov") ||
                    item.Contains(".mpg"))
                {
                    ListaVideo.Add(item);
                }


            }

            foreach (string item in ListaImagem)
            {
                int index = 0;
                int tamanho = 0;
                string nomeArquivo = "";              
                if (item.Contains("Downloads"))
                {
                    index = item.IndexOf(@"Downloads") + 9;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalImagem + nomeArquivo);
                        
                        File.Move(item, LocalImagem + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Imagens");
                    }
                }
                else if (item.Contains("Área de Trabalho"))
                {
                    index = item.IndexOf(@"Área de Trabalho") + 16;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalImagem + nomeArquivo);
                        File.Move(item, LocalImagem + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Imagens");
                    }
                }                
                else if (item.Contains("Documentos"))
                {
                    index = item.IndexOf(@"Documentos") + 10;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalImagem + nomeArquivo);
                        File.Move(item, LocalImagem + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Imagens");
                    }
                }
                else if (item.Contains("Music"))
                {
                    index = item.IndexOf(@"Music") + 5;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalImagem + nomeArquivo);
                        File.Move(item, LocalImagem + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Imagens");
                    }
                }
                else if (item.Contains("Videos"))
                {
                    index = item.IndexOf(@"Videos") + 6;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalImagem + nomeArquivo);
                        File.Move(item, LocalImagem + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Imagens");
                    }
                }
            }

            foreach (string item in ListaDocumento)
            {
                int index = 0;
                int tamanho = 0;
                string nomeArquivo = "";
                if (item.Contains("Downloads"))
                {
                    index = item.IndexOf(@"Downloads") + 9;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalDocumento + nomeArquivo);
                        File.Move(item, LocalDocumento + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Documento");
                    }
                }
                else if (item.Contains("Área de Trabalho"))
                {
                    index = item.IndexOf(@"Área de Trabalho") + 16;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalDocumento + nomeArquivo);
                        File.Move(item, LocalDocumento + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Documento");
                    }
                }
                else if (item.Contains("Imagens"))
                {
                    index = item.IndexOf(@"Imagens") + 7;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalDocumento + nomeArquivo);
                        File.Move(item, LocalDocumento + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Documento");
                    }
                }
                else if (item.Contains("Documentos"))
                {
                    index = item.IndexOf(@"Documentos") + 10;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalDocumento + nomeArquivo);
                        File.Move(item, LocalDocumento + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Documento");
                    }
                }
                else if (item.Contains("Music"))
                {
                    index = item.IndexOf(@"Music") + 5;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalDocumento + nomeArquivo);
                        File.Move(item, LocalDocumento + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Documento");
                    }
                }
                else if (item.Contains("Videos"))
                {
                    index = item.IndexOf(@"Videos") + 6;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalDocumento + nomeArquivo);
                        File.Move(item, LocalDocumento + nomeArquivo, true);
                    }
                    catch(Exception c)
                    {
                        Console.WriteLine("Erro ao mover Documento");
                    }
                }
            }

            foreach (string item in ListaMusica)
            {
                int index = 0;
                int tamanho = 0;
                string nomeArquivo = "";
                if (item.Contains("Downloads"))
                {
                    index = item.IndexOf(@"Downloads") + 9;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalMusica + nomeArquivo);
                        File.Move(item, LocalMusica + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Musica");
                    }
                }
                else if (item.Contains("Área de Trabalho"))
                {
                    index = item.IndexOf(@"Área de Trabalho") + 16;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalMusica + nomeArquivo);
                        File.Move(item, LocalMusica + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Musica");
                    }
                }
                else if (item.Contains("Imagens"))
                {
                    index = item.IndexOf(@"Imagens") + 7;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalMusica + nomeArquivo);
                        File.Move(item, LocalMusica + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Musica");
                    }
                }
                else if (item.Contains("Documentos"))
                {
                    index = item.IndexOf(@"Documentos") + 10;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalMusica + nomeArquivo);
                        File.Move(item, LocalMusica + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Musica");
                    }
                }
                
                else if (item.Contains("Videos"))
                {
                    index = item.IndexOf(@"Videos") + 6;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalMusica + nomeArquivo);
                        File.Move(item, LocalMusica + nomeArquivo, true);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao mover Musica");
                    }
                }
            }

            foreach (string item in ListaVideo)
            {
                int index = 0;
                int tamanho = 0;
                string nomeArquivo = "";
                if (item.Contains("Downloads"))
                {
                    index = item.IndexOf(@"Downloads") + 9;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalVideo + nomeArquivo);
                       
                        File.Move(item, LocalVideo + nomeArquivo);
                        
                    }
                    catch(Exception c)
                    {
                        Console.WriteLine("Erro ao mover Video "+c);
                    }
                }
                else if (item.Contains("Área de Trabalho"))
                {
                    index = item.IndexOf(@"Área de Trabalho") + 16;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalVideo + nomeArquivo);
                        File.Move(item, LocalVideo + nomeArquivo, true);
                    }
                    catch (Exception c)
                    {
                        Console.WriteLine("Erro ao mover Video " + c);
                    }
                }
                else if (item.Contains("Imagens"))
                {
                    index = item.IndexOf(@"Imagens") + 7;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalVideo + nomeArquivo);
                        File.Move(item, LocalVideo + nomeArquivo, true);
                    }
                    catch (Exception c)
                    {
                        Console.WriteLine("Erro ao mover Video " + c);
                    }
                }
                else if (item.Contains("Documentos"))
                {
                    index = item.IndexOf(@"Documentos") + 10;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalVideo + nomeArquivo);
                        File.Move(item, LocalVideo + nomeArquivo, true);
                    }
                    catch (Exception c)
                    {
                        Console.WriteLine("Erro ao mover Video " + c);
                    }
                }
                else if (item.Contains("Music"))
                {
                    index = item.IndexOf(@"Music") + 5;
                    tamanho = item.Length - index;
                    nomeArquivo = item.Substring(index, tamanho);
                    try
                    {
                        //Console.WriteLine(LocalVideo + nomeArquivo);
                        File.Move(item, LocalVideo + nomeArquivo, true);
                    }
                    catch (Exception c)
                    {
                        Console.WriteLine("Erro ao mover Video " + c);
                    }
                }
                
            }
           
        }
    }
}
