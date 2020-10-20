namespace CustomerFeedBack.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerReview")]
    public partial class CustomerReview
    {
        public int ID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        [JsonRequired]
        public decimal? Rating { get; set; }

        [StringLength(250)]
        public string ReviewComments { get; set; }

        [ForeignKey("Product")]
        public int? ProductID { get; set; }


        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; } = DateTime.Now;

        [JsonIgnore]
        public virtual Product Product { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
