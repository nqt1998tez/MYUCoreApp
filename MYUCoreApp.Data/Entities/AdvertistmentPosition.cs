using MYUCoreApp.Infrastructure.Sharekernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MYUCoreApp.Data.Entities
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition : DomainEntity<string>
    {
        [StringLength(20)]
        public string PageId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public  AdvertistmentPage AdvertistmentPage { get; set; }

        public  ICollection<Advertistment> Advertistments { get; set; }
    }
}
