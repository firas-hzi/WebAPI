using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    
    public class WebAPIController : ApiController
    {



        [Route("api/WebAPI/Push")]
        [HttpPost]
        public void Push([FromBody]string[] values)
        {
            DataTable table = new DataTable();
            string query = "insert into example (username,project,date) values  ('" + values[0] + "','" + values[1] + "', cast('" + values[2] + "' as datetime))";
            DAL.connect(query);
           
        }




        [Route("api/WebAPI/Pull")]
        [HttpGet]
       
        public DataTable Pull()
        {
            string query = "select * from example";
            DataTable all = DAL.connect(query);
            return all;
        }




        [Route("api/WebAPI/Free/{s}")]
        [HttpDelete]
        public void Free([FromUri]string s)
        {
            string query = "delete from example where id= '" + s + "'";
            DAL.connect(query);
        }


        [Route("api/WebAPI/Change")]
        [HttpPut]
        public void Change([FromBody]string[] param)
        {
            string query = "update example set username='" + param[0] + "', project='" + param[1] + "', date=cast('" + param[2] + "' as datetime) where id ="+param[3]+"";
            DAL.connect(query);
        }
    }
}
