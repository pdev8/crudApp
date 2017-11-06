using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Domain
{
    public class Trainer
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public string Bio { get; set; }
    }
}