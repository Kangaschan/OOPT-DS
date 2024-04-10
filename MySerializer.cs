using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WinFormsApp1;

namespace OOTP
{
    internal static class MySerializer
    {
        
        [XmlInclude(typeof(Human)), XmlInclude(typeof(Treant)), XmlInclude(typeof(FlyingCreature)), XmlInclude(typeof(Elf)), XmlInclude(typeof(Dwarf)), XmlInclude(typeof(Dragon))]
        public static void SerializeXml<T>(string filename, T[] arr) where T : LivingCreature
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, arr);
            }
        }

        public static LivingCreature[] DeserializeXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LivingCreature[]));
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
                LivingCreature[] arr = (LivingCreature[])serializer.Deserialize(stream);
                return arr;
            }
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public static void SerializeObject<T>(T obj, string filename)
        {

            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            using (var ms = new MemoryStream())
            {
                var formatter = new DataContractSerializer(typeof(T));
                formatter.WriteObject(ms, obj);

                try
                {
                    File.WriteAllBytes(filename, ms.ToArray());
                    MessageBox.Show("Обьекты сохранены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении массива байтов: " + ex.Message);
                }
            }
           
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public static T DeserializeObject<T>(string filename)
        {
            try
            {
                byte[] data = File.ReadAllBytes(filename);
                if (data == null || data.Length == 0)
                    throw new ArgumentNullException(nameof(data));

                using (var ms = new MemoryStream(data))
                {
                    var formatter = new DataContractSerializer(typeof(T));
                    MessageBox.Show("Обьекты успешно восстановлены.");
                    return (T)formatter.ReadObject(ms);
                }
    
            }
            catch (Exception ex)
            {
                object t = null;
                MessageBox.Show("Ошибка при загрузке массива байтов: " + ex.Message);
                return (T)t;
            } 
        }

    }
}
