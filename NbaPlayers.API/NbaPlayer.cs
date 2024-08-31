namespace NbaPlayers.API
{
    public class NbaPlayer
    {
        public int Id { get; set; }
        public string NickName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
    }
}
