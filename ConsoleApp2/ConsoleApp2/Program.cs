using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		private static readonly log4net.ILog log =
			log4net.LogManager.GetLogger(
				System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private static readonly log4net.ILog confluentKafkaLog =
			log4net.LogManager.GetLogger(
				"Confluent.Kafka");

		static void Main(string[] args)
		{
			log.Info("Hello logging world!");

			confluentKafkaLog.Error("Confluent.Kafka error!");

			Console.WriteLine("Hit enter");
			Console.ReadLine();
		}
	}
}
