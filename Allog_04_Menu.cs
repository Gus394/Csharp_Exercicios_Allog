namespace Projeto_Aula_4;
public class Menu
{
    List<Cliente> clientes;
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
        //clientes.FindIndex(cliente => cliente.id = 2); if -1
    }

    public static Cliente Info_Cliente() {
        Cliente cliente = new Cliente();
        Console.WriteLine("Nome: ");
        cliente.nome = Console.ReadLine();
        Console.WriteLine("Endereco: ");
        cliente.endereco = Console.ReadLine();
        Console.WriteLine("Telefone: ");
        cliente.telefone = Console.ReadLine();
        Console.WriteLine("Email: ");
        cliente.email = Console.ReadLine();

        return cliente;
    }

    public void Cadastro(string caminho, List<Cliente> clientes) {
        Cliente cliente = Info_Cliente();
        cliente.id = ultimo_id + 1;

        string linha;

    }

    public Menu()
    {
        clientes = Ler_arquivo("Registro_clientes.csv");
    }
}
