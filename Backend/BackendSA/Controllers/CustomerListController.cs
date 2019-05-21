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
                var commandText = "select idUserThing, name, kind from UsersThings as t where t.UserId = @userId";
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

        [HttpPost("{userId}/{name}/{kind}")]
        public void AddShop(string userId, string name, string kind)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "INSERT INTO UsersThings (name, kind, UserId) VALUES (@name, @kind, @UserId)";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    command.Parameters.Add("@kind", SqlDbType.VarChar, 100).Value = kind;
                    command.Parameters.Add("@UserId", SqlDbType.VarChar, 100).Value = userId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        [HttpDelete("{IdThing}/{IdUser}")]
        public void DeleteShop(int IdThing, string IdUser)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "DELETE FROM UsersThings WHERE idUserThing = @IdThing and UserId = @IdUser";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@IdThing", SqlDbType.Int, 100).Value = IdThing;
                    command.Parameters.Add("@IdUser", SqlDbType.VarChar, 100).Value = IdUser;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}