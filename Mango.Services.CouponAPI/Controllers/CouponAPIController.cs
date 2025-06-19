﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet] //endpoint
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error occurred while processing your request.");
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public object Get( int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(u => u.CouponId==id);
                return obj;
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error occurred while processing your request.");
            }
        }
    }
}
