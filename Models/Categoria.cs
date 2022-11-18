namespace e_commerce.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Carro> Carros { get; set; }
    }
}
