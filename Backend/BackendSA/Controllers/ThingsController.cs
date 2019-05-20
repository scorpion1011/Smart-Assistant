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
    [Route("api/thing")]
    [ApiController]
    public class ThingsController : Controller
    {
        string connString;
        public ThingsController(IConfiguration configuration)
        {
            connString = configuration.GetConnectionString("SmartAssistantDatabase");
        }

        [HttpGet("{idShop}")]
        public List<dynamic> GetThings(int idShop)
        {
            var thingsList = new List<dynamic>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = @"select t.idThing, name, kind, price from Things as t, ThingAtShop as ts where ts.idShop = @idShop and t.idThing = ts.idThing";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@idShop", System.Data.SqlDbType.Int, 100).Value = idShop;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            thingsList.Add(new
                            {
                                idThing = reader.GetInt32(0),
                                name = reader.GetString(1),
                                kind = reader.GetString(2),
                                price = reader.GetInt32(3)
                            });
                        }
                    }

                    connection.Close();
                }
            }

            return thingsList;
        }

        [HttpPost("{shopId}/{name}/{kind}/{price}")]
        public void AddShop(string shopId, string name, string kind, int price)
        {
            int newId;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "select idThing from Things where name = @name and kind = @kind";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    command.Parameters.Add("@kind", SqlDbType.VarChar, 100).Value = kind;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            commandText = "INSERT INTO Things (name, kind) VALUES (@name, @kind) SELECT @@IDENTITY";
                            using (SqlCommand command1 = new SqlCommand(commandText))
                            {
                                command1.Connection = connection;
                                command1.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                                command1.Parameters.Add("@kind", SqlDbType.VarChar, 100).Value = kind;
                                newId = Convert.ToInt32(command1.ExecuteScalar());
                            }
                        }
                        else
                        {
                            newId = reader.GetInt32(0);
                        }
                    }
                    connection.Close();
                }

                commandText = "INSERT INTO ThingAtShop (idShop, idThing, price) VALUES (@idShop, @idThing, @price)";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@idShop", SqlDbType.VarChar, 100).Value = shopId;
                    command.Parameters.Add("@idThing", SqlDbType.Int, 100).Value = newId;
                    command.Parameters.Add("@price", SqlDbType.Int, 100).Value = price;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        [HttpDelete("{IdShop}/{IdThing}")]
        public void DeleteShop(int IdShop, int IdThing)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                var commandText = "DELETE FROM ThingAtShop WHERE idShop = @IdShop and idThing = @IdThing";
                using (SqlCommand command = new SqlCommand(commandText))
                {
                    command.Connection = connection;
                    command.Parameters.Add("@IdShop", SqlDbType.Int, 100).Value = IdShop;
                    command.Parameters.Add("@IdThing", SqlDbType.Int, 100).Value = IdThing;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}