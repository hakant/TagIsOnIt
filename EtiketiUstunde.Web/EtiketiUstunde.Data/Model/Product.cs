using System;

namespace EtiketiUstunde.Data.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string Name { get; set; }
        public string Owner { get; set; }
        public int DaysSincePosted { get; set; }
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        public int LikeCount { get; set; }

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
