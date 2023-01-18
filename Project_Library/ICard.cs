namespace Project_Library
{
    public interface ICard
    {
        public PublicationType DocumentType { get; set; }
        public int CardId { get; set; }

        public void ShowCardData() { }
    }
}