﻿using Shopcuatoi.Infrastructure.Domain.Models;

namespace Shopcuatoi.Core.Domain.Models
{
    public class StateOrProvince : Entity
    {
        public long CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}