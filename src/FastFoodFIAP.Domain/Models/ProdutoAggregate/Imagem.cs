using GenericPack.Domain;

namespace FastFoodFIAP.Domain.Models.ProdutoAggregate
{
    public partial class Imagem : ValueObject
    {
        public int Id { get; private set; }
        public string Url { get; private set; } = "";


        private Imagem() { }

        public Imagem(string url){
            Url = url;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
            yield return Url;            
        }
    }
}