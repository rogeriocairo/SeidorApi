namespace SeidorApi.Core.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string Senha { get; set; }

        public required string Email { get; set; }
    }
}
