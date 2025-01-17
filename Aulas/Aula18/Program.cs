namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        //1. Criar um arquivo
        //string content = "Hello World!";

        //File.WriteAllText("file2.txt", content);

        //Console.WriteLine("Arquivo criado com sucesso");

        //2. Criar arquivo em local específico
        //string path = @"C:\Users\Antônio Rocha\source\repos\Youtube\Curso-Csharp-Dotnet\Aulas\Aula18\fileName.txt";

        //string content = "Hello World";

        //File.WriteAllText(path, content);

        //Console.WriteLine("Arquivo criado com sucesso");

        ////3.Criar um arquivo Word 
        //string path = @"C:\Users\Antônio Rocha\source\repos\Youtube\Curso-Csharp-Dotnet\Aulas\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filhePath = path + fileName;

        //string content = "Hello World";

        //File.WriteAllText(filhePath, content);

        //Console.WriteLine("Arquivo Word criado com sucesso");

        //4. Inserir um parágrafo em um arquivo
        //string path = @"C:\Users\Antônio Rocha\source\repos\Youtube\Curso-Csharp-Dotnet\Aulas\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filePath = path + fileName;

        //string additionalContent = "| Curso de C# e .NET";

        //File.AppendAllText(filePath, additionalContent);

        //Console.WriteLine("Arquivo Atualizado com sucesso");

        //5. Ler o arquivo
        string path = @"C:\Users\Antônio Rocha\source\repos\Youtube\Curso-Csharp-Dotnet\Aulas\Aula18\";
        string fileName = "myDocument.Doc";
        string filePath = path + fileName;

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);
    }
}