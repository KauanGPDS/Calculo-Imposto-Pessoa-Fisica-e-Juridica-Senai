using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)? ");
            string resp = Console.ReadLine().ToLower();
            
            if (resp == "f")
            {
                Pessoa_fisica p2 = new Pessoa_fisica();
                p2.nome = nome;
                p2.endereco = endereco;
                Console.WriteLine("Informe o CPF: ");
                p2.cpf = Console.ReadLine();
                Console.WriteLine("Informe o RG: ");
                p2.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                p2.Pagar_Imposto(val_pag);
                
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome: " + p2.nome);
                Console.WriteLine("RG: " + p2.rg);
                Console.WriteLine("CPF: " + p2.cpf);
                Console.WriteLine("Endereço: " + p2.endereco);
                Console.WriteLine("Valor da Compra: " + p2.valor.ToString("C"));
                Console.WriteLine("Imposto: " + p2.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar: " + p2.total.ToString("C"));
            }
            
            if (resp == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = nome;
                pj.endereco = endereco;
                Console.WriteLine("Informe o CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe a IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                
                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("Nome: " + pj.nome);
                Console.WriteLine("Endereço: " + pj.endereco);
                Console.WriteLine("CNPJ: " + pj.cnpj);
                Console.WriteLine("IE: " + pj.ie);
                Console.WriteLine("Valor da Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar: " + pj.total.ToString("C"));
            }
        }
    }
}