using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Request
{
    public class TrainerAddRequest
    {
        public int UserProfileId { get; set; }
        public string Bio { get; set; }
    }
}