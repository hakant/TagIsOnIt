using System;

namespace EtiketiUstunde.Data.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        public int Id { get; set; }

        public int DivisionId { get; set; }
        public virtual Division Division { get; set; }

        public int CategoryGroupId { get; set; }
        public virtual CategoryGroup CategoryGroup { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Higher the number, higher the priority
        /// </summary>
        public int PriorityScore { get; set; }

        private DateTime _dateCreated = default(DateTime);
        public DateTime DateCreated
        {
            get
            {
                return (this._dateCreated == default(DateTime))
                ? DateTime.UtcNow
                : this._dateCreated;
            }
            set { this._dateCreated = value; }
        }
    }
}