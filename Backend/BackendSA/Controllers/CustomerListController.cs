using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BackendSA.Controllers
{
    [Route("api/list")]
    [ApiController]
    public class CustomerListController : Controller
    {
        string connString;
        public CustomerListController(IConfiguration configuration)
        {
            connString = configuration.GetConnectionString("SmartAssistantDatabase");
        }

        [HttpGet("{userId}")]
        public List<dynamic> GetUsersList(string userId)
        {
            var list = new List<dynamic>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "select idThing, name, kind from Things as t, CustomerLists as l where t.CustomerListidList = l.idList and l.idUser = @userId";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@userId", SqlDbType.VarChar, 100).Value = userId;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                IdThing = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Kind = reader.GetString(2)
                            });
                        }
                    }

                    connection.Close();
                }
            }

            return list;
        }

        [HttpPost("{userId}/{name}/{latitude}/{longitude}/{area}")]
        public void AddShop(string userId, string name, int latitude, int longitude, int area)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "INSERT INTO Shops (name, latitude, longitude, area, UserId) VALUES (@name, @latitude, @longitude, @area, @UserId)";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    command.Parameters.Add("@latitude", SqlDbType.Int, 100).Value = latitude;
                    command.Parameters.Add("@longitude", SqlDbType.Int, 100).Value = longitude;
                    command.Parameters.Add("@area", SqlDbType.Int, 100).Value = area;
                    command.Parameters.Add("@UserId", SqlDbType.VarChar, 100).Value = userId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}