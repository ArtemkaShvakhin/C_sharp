using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firma
{
   // [Serializable]
    public interface ISerializer
    {
        IEnumerable<MyCustomCollection<Otdel>> DeSerializeByLINQ(string fileName)
        {

        }
        IEnumerable<MyCustomCollection<Otdel>> DeSerializeXML(string fileName) 
            {

            } 
        IEnumerable<MyCustomCollection<Otdel>> DeSerializeJSON(string fileName)
        {
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                Person tom = new Person() { Name = "Tom", Age = 35 };
                await JsonSerializer.SerializeAsync<Person>(fs, tom);
            }
        }
        void SerializeByLINQ(IEnumerable<MyCustomCollection<Otdel>> xxx, string fileName)
        {

        }
        void SerializeXML(IEnumerable<MyCustomCollection<Otdel>> xxx, string fileName)
        {

        }
        void SerializeJSON(IEnumerable<MyCustomCollection<Otdel>> xxx, string fileName)
        {

        }
        DeSerializeXXX
            DeSerializeXXX
            DeSerializeXXX
            DeSerializeXXX
    }
}