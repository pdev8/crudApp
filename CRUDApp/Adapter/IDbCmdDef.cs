﻿using System.Data;

namespace CRUDApp.Adapter
{
    public interface IDbCmdDef
    {
        string DbCommandText { get; set; }
        CommandType DbCommandType { get; set; }
        IDbDataParameter[] DbParameters { get; set; }
    }
}