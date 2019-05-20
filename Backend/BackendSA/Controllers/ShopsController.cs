using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace BackendSA.Controllers
{
    [Route("api/shop")]
    [ApiController]
    public class ShopsController : Controller
    {
        string connString;
        public ShopsController(IConfiguration configuration)
        {
            connString = configuration.GetConnectionString("SmartAssistantDatabase");
        }

        [HttpGet("{userId}")]
        public List<dynamic> GetUsersShops(string userId)
        {
            var shops = new List<dynamic>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "select idShop, name, latitude, longitude, area from Shops as s where s.UserId = @userId";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@userId", SqlDbType.VarChar, 100).Value = userId;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            shops.Add(new
                            {
                                idShop = reader.GetInt32(0),
                                name = reader.GetString(1),
                                latitude = reader.GetInt32(2),
                                longitude = reader.GetInt32(3),
                                area = reader.GetInt32(4)
                            });
                        }
                    }

                    connection.Close();
                }
            }

            return shops;
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

        [HttpDelete("{IdShop}")]
        public void DeleteShop(int IdShop)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "DELETE FROM Shops WHERE idShop = @IdShop";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@IdShop", SqlDbType.Int, 100).Value = IdShop;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}