using System.Collections.Generic;

namespace EtiketiUstunde.Web.Models
{
    public class DivisionModel
    {
        public int Id;
        public string Name;

        /// <summary>
        /// Higher the number, higher the priority
        /// </summary>
        public int PriorityScore;

        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}