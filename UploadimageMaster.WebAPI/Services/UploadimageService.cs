
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadimageMaster.WebAPI.DataProvider;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using UploadimageMaster.WebAPI.Models.Error;
using UploadimageMaster.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace UploadimageMaster.WebAPI.Services
{


    public class UploadimageService : IUploadimageService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;
        private readonly IConfiguration _config;
        private readonly IGlobalService _global;
        ErrResponse err = new ErrResponse();

        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        string moduleName = "";
        public UploadimageService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("Uploadimage:Uploadimage");
        }

        public string Uploadimage(string savedFilePath)
        {

            ErrResponse err = new ErrResponse();
            string customerCode = _global.GetCustomerCode();

            var customer = (from p in _context.MstCustprofile
                            where p.ActiveFlagC == "A"
                            && p.CustCodeVc == customerCode
                            select p).FirstOrDefault();
            customer.ProfilePicName = savedFilePath;

            _context.SaveChanges();

            err.Message = savedFilePath;
            return err.Message;


        }
    }
}
