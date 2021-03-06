﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DbConnect.Adapter;
using DbConnect.Tools;
using MVCApp.Interfaces;
using MVCApp.Models.Domain;
using MVCApp.Models.Request;

namespace MVCApp.Services
{
    public class TrainerService : BaseService, ITrainerService
    {
        public IEnumerable<Trainer> GetAll()
        {
            DbCmdDef cmdDef = new DbCmdDef()
            {
                DbCommandText = "dbo.Trainer_SelectAll",
                DbCommandType = CommandType.StoredProcedure
            };
            return Adapter.LoadObject<Trainer>(cmdDef);
        }

        public Trainer GetById(int id)
        {
            try
            {
                return Adapter.LoadObject<Trainer>(new DbCmdDef()
                {
                    DbCommandText = "dbo.Trainer_SelectById",
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

        public int Insert(TrainerAddRequest model)
        {
            int id = 0;

            DbCmdDef cmdDef = new DbCmdDef
            {
                DbCommandText = "dbo.Trainer_Insert",
                DbCommandType = CommandType.StoredProcedure,
                DbParameters = new[]
                {
                    SqlDbParameter.Instance.BuildParameter("@Bio", model.Bio, SqlDbType.NVarChar),
                    SqlDbParameter.Instance.BuildParameter("@UserProfileId", model.UserProfileId, SqlDbType.Int),
                    SqlDbParameter.Instance.BuildParameter("@Id", id, SqlDbType.Int, paramDirection: ParameterDirection.Output)
                }
            };

            Adapter.ExecuteQuery(cmdDef, delegate(IDataParameterCollection collection)
            {
                Int32.TryParse(collection["@Id"].ToString(), out id);
            });

            return id;
        }

        public void Update(TrainerUpdateRequest model)
        {
            DbCmdDef cmdDef = new DbCmdDef
            {
                DbCommandText = "dbo.Trainer_UpdateById",
                DbCommandType = CommandType.StoredProcedure,
                DbParameters = new[]
                {
                    SqlDbParameter.Instance.BuildParameter("@Bio", model.Bio, SqlDbType.NVarChar),
                    SqlDbParameter.Instance.BuildParameter("@UserProfileId", model.UserProfileId, SqlDbType.Int),
                    SqlDbParameter.Instance.BuildParameter("@Id", model.Id, SqlDbType.Int)
                }
            };

            Adapter.ExecuteQuery(cmdDef);
        }

        public void Delete(int id)
        {
            DbCmdDef cmdDef = new DbCmdDef
            {
                DbCommandText = "dbo.Trainer_DeleteById",
                DbCommandType = CommandType.StoredProcedure,
                DbParameters = new[]
                {
                    SqlDbParameter.Instance.BuildParameter("@Id", id, SqlDbType.Int)
                }
            };

            Adapter.ExecuteQuery(cmdDef);
        }
    }
}