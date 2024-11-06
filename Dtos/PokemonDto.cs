namespace PokemonApi.Dtos
{

    public class PokemonApiResponse
    {
        public List<PokemonDto> results { get; set; }
    }
    public class PokemonDto
    {
        public string name { get; set; }
        public int id { get; set; }

    }
}