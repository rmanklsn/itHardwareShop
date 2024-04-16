using Store.Web.Models;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Store.Web
{
    public static class SessionExtensions
    {
        private const string key = "Cart";

        public static void Set(this ISession session, Cart value)
        {
            if (value == null)
                return;

            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, leaveOpen: false))
            {
                writer.Write(value.Items.Count);
                foreach (var item in value.Items)
                {
                    writer.Write(item.Key);
                    writer.Write(item.Value);
                }

                writer.Write(value.Amount);

                writer.Flush();  // Ensure all data is written to the stream
                session.Set(key, stream.ToArray());
            }
        }

        public static bool TryGetCart(this ISession session, out Cart value)
        {
            if (session.TryGetValue(key, out byte[] buffer))
            {
                using (var stream = new MemoryStream(buffer))
                using (var reader = new BinaryReader(stream, Encoding.UTF8, leaveOpen: false))
                {
                    int length = reader.ReadInt32();
                    value = new Cart();

                    for (int i = 0; i < length; i++)
                    {
                        int hardwareId = reader.ReadInt32();
                        int count = reader.ReadInt32();
                        value.Items.Add(hardwareId, count);
                    }

                    value.Amount = reader.ReadInt32();

                    return true;
                }
            }

            value = null;
            return false;
        }
    }
}
