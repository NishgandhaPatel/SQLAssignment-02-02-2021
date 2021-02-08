using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPocoClass
{
	//POCO class
	class CustomerPocoClass
	{
		public int CId { get; set; }
		public string CName { get; set; }
		public DateTime DOB { get; set; }
		public string City { get; set; }
	}

	class Program
	{
		static void ExtractDetails()
		{
			SqlConnection cn = null;
			SqlCommand cm = null;
			SqlDataReader dr = null;
			List<CustomerPocoClass> detailList;
			try
			{
				detailList = new List<CustomerPocoClass>();
				using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
				{
					using (cm = new SqlCommand("SELECT * FROM tblBankCustomer", cn))
					{
						cn.Open();
						using (dr = cm.ExecuteReader(CommandBehavior.CloseConnection))
						{
							while (dr.Read())
							{
								detailList.Add(new CustomerPocoClass
								{
									CId = dr.GetFieldValue<int>(dr.GetOrdinal("CId")),
									CName = dr.GetFieldValue<string>(dr.GetOrdinal("CName")),
									DOB = dr.GetFieldValue<DateTime>(dr.GetOrdinal("DOB")),
									City = dr.GetFieldValue<string>(dr.GetOrdinal("City"))
								});
							}
						}
					}
				}
				Console.WriteLine("******************* Customer Poco class Data ***********************");

				var res = detailList.GetEnumerator();
				while (res.MoveNext())
				{
					Console.WriteLine("Cid as     : " + res.Current.CId);
					Console.WriteLine("CName as   : " + res.Current.CName);
					Console.WriteLine("DOB as     : " + res.Current.DOB);
					Console.WriteLine("City as    : " + res.Current.City);
					Console.WriteLine("----------------------------------------------------");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		static void Main(string[] args)
		{
			ExtractDetails();
			Console.ReadLine();
		}
	}
}
