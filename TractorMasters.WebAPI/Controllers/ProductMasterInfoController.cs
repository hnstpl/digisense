using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Models.Error;
using TractorMasters.WebAPI.Models.ProductMasterInfo;
using TractorMasters.WebAPI.Services;

namespace TractorMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMasterInfoController : ControllerBase
    {
        private readonly IProductMasterInfoService _productMasterInfo;

        private readonly IGlobalService _global;


        public ProductMasterInfoController(IProductMasterInfoService productMasterInfo, IGlobalService Global)
        {
            _productMasterInfo = productMasterInfo;;
            _global = Global;
        }
        [HttpGet]      
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_ProductMasters([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _productMasterInfo.GetProductMasterInfo(input.languagecode, customerCode);



             return Ok(mastersModel); // Request.CreateResponse(HttpStatusCode.OK, masterModel);                
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
                //return Request.CreateResponse(HttpStatusCode.BadRequest, err);
            }

        }
    }
}
