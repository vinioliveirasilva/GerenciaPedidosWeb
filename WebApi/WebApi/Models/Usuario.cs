using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Helper;

namespace WebApi.Models
{
    public class Usuario
    {
        [AttributeType(PrimaryKey = true)]
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}