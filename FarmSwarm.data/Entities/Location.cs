namespace FarmSwarm.data.Entities
{
    public class Location : EntityBase 
    {
        public int DeckId { get; set; }
        public virtual Deck Deck { get; set; }        
        public int DeckPosition { get; set; }
    }
}
