
namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza (int ID, Serie objeto)
        {
            listaSerie[ID] = objeto;
        }

        public void Exclui (int ID)
        {
            listaSerie[ID].Excluir();
        }

        public void Insere (Serie entidade)
        {
            listaSerie.Add(objeto);
        }
        
        public void Lista ()
        {
            return listaSerie;
        }

        public int ProximoID()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorID()
        {
            return listaSerie[ID];
        }
    }
}