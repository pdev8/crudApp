using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DbConnect.Adapter;
using MVCApp.Interfaces;
using MVCApp.Models.Domain;

namespace MVCApp.Services
{
    public class TrainerService: BaseService, ITrainerService
    {
        public IEnumerable<Trainer> GetAll()
        {
            DbCmdDef cmdDef = new DbCmdDef()
            {
                DbCommandText = "dbo.Trainer_SelectAll",
                DbCommandType = System.Data.CommandType.StoredProcedure
            };
            return Adapter.LoadObject<Trainer>(cmdDef);
        }
            
    }
}