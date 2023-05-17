using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
public class Menu
{
    List<Cliente> clientes;
    string caminho;
    int ultimo_id;

    public List<Cliente> Ler_arquivo(string caminho)
    {

        List<Cliente> clientes = new List<Cliente>();

        string[] linhas = File.ReadAllLines(caminho);

        foreach (string linha in linhas)
        {
            string[] campos = linha.Split(',');

            Cliente cliente = new Cliente
            {
                id = int.Parse(campos[0]),
                nome = campos[1],
                endereco = campos[2],
                telefone = campos[3],
                email = campos[4],
            };

            ultimo_id = cliente.id;
            clientes.Add(cliente);
        }

        return clientes;
    }

    public static void Registrar(string caminho, List<Cliente> clientes)
    {
        List<string> linhas = new List<string>();

        foreach (Cliente cliente in clientes)
        {
            string linha = string.Join(",", cliente.id, cliente.nome, cliente.endereco, cliente.telefone, cliente.email);
            linhas.Add(linha);
        }
        File.WriteAllLines(caminho, linhas);
    }

    public static Cliente Info_Cliente()
    {
        Cliente cliente = new Cliente();
        Console.WriteLine("Nome: ");     cliente.nome = Console.ReadLine();
        Console.WriteLine("Endereco: "); cliente.endereco = Console.ReadLine();
        Console.WriteLine("Telefone: "); cliente.telefone = Console.ReadLine();
        
        while (true) // validar e-mail
        {
            Console.WriteLine("Email: ");
            cliente.email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(cliente.email);
            if (match.Success)
                break;
            Console.WriteLine("Email invalido, tente novamente.");
        }
        
        return cliente;
    }

    public void Cadastro()
    {
        Cliente cliente = Info_Cliente();
        cliente.id = ultimo_id + 1;

        clientes.Add(cliente);
        Registrar(caminho, clientes);
    }

    public void Editar() // colocar try catch e verificação se -1
    {
        Console.WriteLine("Digite o ID do cliente: ");
        int id = int.Parse(Console.ReadLine());
        int indice;

        indice = clientes.FindIndex(cliente => cliente.id == id); //if -1
        if (indice == -1)
            Console.WriteLine("ID não encontrado.");
        else
        {
            clientes[indice] = Info_Cliente();
            Registrar(caminho, clientes);
        }
    }

    public void Excluir()
    {
        Console.WriteLine("Digite o ID do cliente a ser excluido: ");
        int id = int.Parse(Console.ReadLine());
        int indice;

        indice = clientes.FindIndex(cliente => cliente.id == id); //if -1
        if (indice == -1)
            Console.WriteLine("ID não encontrado.");
        else
        {
            clientes.RemoveAt(indice);
            Registrar(caminho, clientes);
        }
    }

    public void Listar()
    {
        clientes.ForEach(item => Console.Write(item.id + ", " + item.nome + ", " + item.endereco + ", " + item.telefone + ", " + item.email + "\n"));
    }

    public Menu(string caminho)
    {
        this.caminho = caminho;
        clientes = Ler_arquivo(caminho);
    }
}
