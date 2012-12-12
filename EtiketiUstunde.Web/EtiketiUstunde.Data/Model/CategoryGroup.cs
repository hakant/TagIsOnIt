using System;
using System.Collections.Generic;

namespace EtiketiUstunde.Data.Model
{
    public class CategoryGroup
    {
        public int Id { get; set; }
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

        public ICollection<Category> Categories { get; set; }
    }
}
