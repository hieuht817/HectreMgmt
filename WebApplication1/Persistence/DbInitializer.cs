using HectreMgmt.Domain.Model;
using System.Text;
using System.Text.Json;

namespace HectreMgmt.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Chemicals.Any())
            {
                return; 
            }
            String str = "{\"Id\":\"123\",\"DateOfRegistration\":\"2012-10-21T00:00:00+05:30\",\"Status\":0}";

            byte[] jsonData = Encoding.ASCII.GetBytes(@"[]");


            var readOnlySpan = new ReadOnlySpan<byte>(jsonData);
            var chemicals =
                JsonSerializer.Deserialize<Chemical[]>(readOnlySpan);

            context.Chemicals.AddRange(chemicals);
            context.SaveChanges();
        }

        

    }
}
