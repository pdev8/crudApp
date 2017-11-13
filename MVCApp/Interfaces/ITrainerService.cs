using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.Models.Domain;
using MVCApp.Models.Request;

namespace MVCApp.Interfaces
{
    public interface ITrainerService
    {
        IEnumerable<Trainer> GetAll();
        Trainer GetById(int id);
        int Insert(TrainerAddRequest model);
        void Update(TrainerUpdateRequest model);
        void Delete(int id);
    }
}