using System.Configuration;

namespace СonfectioneryСompany
{
    public class Config
    {
         public static string GetConnectionString()
         {
             return ConfigurationManager.ConnectionStrings["СonfectioneryСompany"].ConnectionString;
         }
    }
}