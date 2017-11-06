using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.Models.Domain;

namespace MVCApp.Interfaces
{
    public interface ITrainerService
    {
        IEnumerable<Trainer> GetAll();
    }
}