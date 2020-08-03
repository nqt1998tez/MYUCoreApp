using MYUCoreApp.Infrastructure.Sharekernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MYUCoreApp.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : DomainEntity<string>
    {
        public string Name { get; set; }

        public ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}
