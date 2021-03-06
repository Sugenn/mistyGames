﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DataLayer
{
    public class DataConnector
    {
        protected OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter();
        public string errorMessage = "";
        public DataConnector(string ConnectionString)
        {
            OleDbConnection Connection1 = new OleDbConnection(ConnectionString);
            this.DataAdapter1.SelectCommand = new OleDbCommand("", Connection1);
            this.DataAdapter1.InsertCommand = new OleDbCommand("", Connection1);
        }
        public DataTable DataSelect(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAdapter1.SelectCommand.CommandText = query;
                DataAdapter1.SelectCommand.Connection.Open();
                DataAdapter1.Fill(dt);
                DataAdapter1.SelectCommand.Connection.Close();
            }
            catch(Exception e)
            {
                errorMessage = e.ToString();
                DataAdapter1.SelectCommand.Connection.Close();
            }
            return dt;
        }

        public int DataInsert(string query)
        {
            int result = 0;
            try
            {
                DataAdapter1.InsertCommand.CommandText = query;
                DataAdapter1.InsertCommand.Connection.Open();
                result = DataAdapter1.InsertCommand.ExecuteNonQuery();
                DataAdapter1.InsertCommand.Connection.Close();
                return result;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
                DataAdapter1.InsertCommand.Connection.Close();
                return 0;
            }
        }

        public int DataUpdate(string query)
        {
            return DataInsert(query);
        }

        public int DataDelete(string query)
        {
            return DataInsert(query);
        }
    }
}
