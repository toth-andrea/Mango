﻿using AutoMapper;

namespace Mango.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Models.Dto.CouponDto, Models.Coupon>();
                config.CreateMap<Models.Coupon, Models.Dto.CouponDto>();
            });
            return mappingConfig;
        }
    }
}
