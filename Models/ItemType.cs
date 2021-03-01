using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("ItemType")]
    public class ItemType
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public Guid ItemCategoryId { get; set; }

        public ItemCategory ItemCategory { get; set; }

        public ICollection<ItemSubType> ItemSubTypes { get; set; }


    }

}
