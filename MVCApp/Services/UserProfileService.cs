using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DbConnect.Adapter;
using DbConnect.Tools;
using MVCApp.Models.Domain;

namespace MVCApp.Services
{
    public class UserProfileService : BaseService
    {
        public IEnumerable<UserProfile> GetAll()
        {
            DbCmdDef cmdDef = new DbCmdDef()
            {
                DbCommandText = "dbo.UserProfile_SelectAll",
                DbCommandType = CommandType.StoredProcedure
            };
            return Adapter.LoadObject<UserProfile>(cmdDef);
        }

        public UserProfile GetById(int id)
        {
            try
            {
                return Adapter.LoadObject<UserProfile>(new DbCmdDef()
                {
                    DbCommandText = "dbo.UserProfile_SelectById",
                    DbCommandType = CommandType.StoredProcedure,
                    DbParameters = new[]
                    {
                        SqlDbParameter.Instance.BuildParameter("@Id", id, SqlDbType.Int)
                    }
                }).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public int Insert()
    }
}