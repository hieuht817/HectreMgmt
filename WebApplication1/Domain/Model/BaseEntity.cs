using System.ComponentModel.DataAnnotations;

namespace HectreMgmt.Domain.Model
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey _id { get; set; }
    }
}
