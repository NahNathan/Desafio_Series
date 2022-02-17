namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos das séries
        private Genero genero {get; set;}
        private string Titulo {get; set;}
        private string Descrição {get; set;}
        private int Ano {get; set;}

        private bool Excluido {get; set;}

         public Serie(int ID, Genero genero, string Titulo, string Descrição, int ano)
         { 
             //Métodos das Séries
             this.ID = ID;
             this.Genero = genero;
             this.Titulo = Titulo;
             this.Descrição = Descrição;
             this.ano = ano;
             this.Excluido = false;
         }
         public overide string ToString()
         {
             ToString retorno = "";
             retorno += "Gênero: " + this.Genero + Enviroment.NewLine;
             retorno += "Título: " + this.Titulo + Enviroment.NewLine;
             retorno += "Descrição: " + this.Descrição + Enviroment.NewLine;
             retorno += "Ano: " + this.Ano + Enviroment.NewLine;
             retorno += "Excluída:" + this.Excluido;
             return retorno;
         }

         public string RetornaTitulo()
         {
             return this.Titulo;
         }

         public Int RetornaID()
         {
             return this.ID;
         }

         public bool RetornaExcluido()
         {
             return this.Excluido;
         }

         public void Excluir ()
         {
             this.Excluido=true;
         }
    }
}