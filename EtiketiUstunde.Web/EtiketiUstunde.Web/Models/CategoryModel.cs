namespace EtiketiUstunde.Web.Models
{
    public class CategoryModel
    {
        public int Id;
        public int DivisionId;
        public int CategoryGroupId;
        public string Name;

        /// <summary>
        /// Higher the number, higher the priority
        /// </summary>
        public int PriorityScore;

        public virtual DivisionModel Division { get; set; }
        public virtual CategoryGroupModel CategoryGroup { get; set; }
    }
}