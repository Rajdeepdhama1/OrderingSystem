using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using DataService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class voterSystemController : ControllerBase
    {
        [HttpGet(Name = "GetCountryList")]
        public DataTable GetCountryList()
        {
            DataTable dtCountry = new DataHelper().GetResults("Select * from Country");
            return dtCountry;
        }

        [HttpGet(Name = "GetStates")]
        public DataTable GetStates(int id)
        {
            DataTable dtStates = new DataHelper().GetResults("Select * from States where CountryID = " + id);
            return dtStates;
        }

        [HttpGet(Name = "GetCities")]
        public DataTable GetCities(int id)
        {
            DataTable dtCities = new DataHelper().GetResults("Select * from Cities where StateID = " + id);
            return dtCities;
        }
        [HttpPost(Name = "Registration")]
        public void Registration([FromBody] RegistrationModel data)
        {
            DataTable dtUsers = new DataHelper().PostValues("INSERT INTO UserData VALUES ('" + data.UserName + "' , '" + data.Phone + "', '" + data.Address + "','" + data.CountryID + "','" + data.StateID + "','" + data.CityID + "')");
            return;
        }
    }
}
