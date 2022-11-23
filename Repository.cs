using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TStore
{
    internal static class Repository
    {
        private const string FileName = "database.dat";
        
        public static void Serialize(Database database, bool append = false)
        {
            using (Stream stream = File.Open(FileName, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, database);
            }
        }

        public static Database Deserialize()
        {
            using (Stream stream = File.Open(FileName, FileMode.Open))
            {
                try
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (Database)binaryFormatter.Deserialize(stream);
                } catch(SerializationException e)
                {
                    Debug.WriteLine(e);
                    return new();
                }
            }
        }
    }
}
