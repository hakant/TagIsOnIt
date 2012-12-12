namespace EtiketiUstunde.Web.Models
{
    public class CategoryGroupModel
    {
        public int Id;
        public string Name;

        /// <summary>
        /// Higher the number, higher the priority
        /// </summary>
        public int PriorityScore;
    }
}