namespace Atividade
{
    class Pessoa_fisica : Cliente
    {
      public string cpf{get; set;}
      public string rg{get; set;}

       public override void Pagar_Imposto(float v){
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;

        }
    }
}