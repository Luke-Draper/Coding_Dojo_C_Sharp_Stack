using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using LostInTheWoods.Models;

namespace LostInTheWoods
{
	public class TrailFactory
	{
		private string connectionString;
		public TrailFactory()
		{
			connectionString = "server=localhost;userid=root;password="+DbConnection.pass+";port=51515;database=lost_in_the_woods;SslMode=None";
		}
		internal IDbConnection Connection
		{
			get {
				return new MySqlConnection(connectionString);
			}
		}
		public void Add(Trail item)
		{
			using (IDbConnection dbConnection = Connection) {
				string query =  "INSERT INTO trails (trail_id, name, description, length, elevation, longitude, latitude) VALUES (@trail_id, @name, @description, @length, @elevation, @longitude, @latitude )";
				dbConnection.Open();
				dbConnection.Execute(query, item);
			}
		}
		public IEnumerable<Trail> FindAll()
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				return dbConnection.Query<Trail>("SELECT * FROM trails");
			}
		}
		public Trail FindByID(int id)
		{
			using (IDbConnection dbConnection = Connection)
			{
				dbConnection.Open();
				return dbConnection.Query<Trail>("SELECT * FROM trails WHERE trail_id = @trail_d", new { trail_d = id }).FirstOrDefault();
			}
		}
	}
}
