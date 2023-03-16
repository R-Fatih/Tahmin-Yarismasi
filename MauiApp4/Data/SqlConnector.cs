

using Microsoft.Data.SqlClient;
namespace MauiApp4.Data
{
	public class SqlConnector
	{
		// SqlConnection connection = new SqlConnection(@"Data Source = SQL8002.site4now.net; Initial Catalog = db_a950c8_subatyeniyarisma; User Id = db_a950c8_subatyeniyarisma_admin; Password=YSKK766CQGxlC5Pp");
		//SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-HQBI6KF\SQLEXPRESS;Initial Catalog=YarismaYeni;Integrated Security=true;TrustServerCertificate=True;");
	SqlConnection connection = new SqlConnection(@"Data Source=SQL8002.site4now.net;Initial Catalog=db_a95478_terketmeknekadar;User Id=db_a95478_terketmeknekadar_admin;Password=Jw3x4Azw;Persist Security Info=True;trustServerCertificate=true;Encrypt = false");

		public SqlConnection Connection()
		{
			return connection;
		}

	}
}
