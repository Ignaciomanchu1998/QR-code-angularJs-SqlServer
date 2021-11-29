using Dao.QRGenerator;
using QRCode.Dao.Utils;
using QRCode.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QRCode.Dao
{
    public class UsersDao: ConnectionDB
    {
        private StructureResponse _struct = new StructureResponse();

        public async Task<StructureResponse> UsersGetAll()
        {
            var u = new List<Users>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("USPUsersList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader readerAsync = await cmd.ExecuteReaderAsync())
                    {
                        while (await readerAsync.ReadAsync())
                        {
                            _struct.code = readerAsync.GetString(0);
                            _struct.message = readerAsync.GetString(1);
                            _struct.messageTitle = readerAsync.GetString(2);
                            if (_struct.code == "1")
                            {
                                var item = new Users();
                                item.idUsers = readerAsync.GetInt32(3);
                                item.qrocode = new QRGenerator().QrGenerate(readerAsync.GetGuid(4));
                                item.name = readerAsync.GetString(5);
                                item.lastName = readerAsync.GetString(6);
                                u.Add(item);
                            }
                        }
                    }
                    con.Close();
                }
                _struct.payload = u;
            }
            catch (Exception ex)
            {
                _struct.code = "0";
                _struct.message = ex.Message;
                _struct.messageTitle = "(Error)";
            }
            return _struct;
        }

    }
}
