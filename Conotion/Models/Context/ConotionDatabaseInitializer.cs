namespace Conotion.Models
{
	using System.Configuration;
	using System.Data.Entity;
	using System.Data.SqlClient;
	using System.IO;
	using Microsoft.SqlServer.Management.Common;
	using Microsoft.SqlServer.Management.Smo;

	public class ConotionDatabaseInitializer : CreateDatabaseIfNotExists<ConotionContext>
	{
		public string ConnectionString
		{
			get
			{
				return ConfigurationManager.AppSettings["ConotionContext"];
			}
		}

		protected override void Seed(ConotionContext context)
		{
			base.Seed(context);

            var script = File.ReadAllText(@"C:\Projects\Archive\Conotion\Conotion\Sql\scenario_1.sql");
			var conn = new SqlConnection(ConnectionString);
			var server = new Server(new ServerConnection(conn));
			server.ConnectionContext.ExecuteNonQuery(script);
		}
	}
}