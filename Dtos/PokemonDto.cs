namespace PokemonApi.Dtos
{
    public class PokemonDto
    {
        public string name { get; set; }
        public int id { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public Sprites sprites { get; set; } // Asegúrate de incluir esta clase si quieres mostrar la imagen
    }

    public class Sprites
    {
        public string front_default { get; set; } // URL de la imagen
    }
}
