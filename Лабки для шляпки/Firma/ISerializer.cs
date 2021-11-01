using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    interface ISerializer
    {
        IEnumerable<MyCustomCollection<Otdel>> DeSerializeByLINQ(string fileName);
        IEnumerable<MyCustomCollection<Otdel>> DeSerializeXML(string fileName);
        IEnumerable<MyCustomCollection<Otdel>> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<MyCustomCollection<Otdel>> xxx, string fileName);
        void SerializeXML(IEnumerable<MyCustomCollection<Otdel>> xxx, string fileName);
        void SerializeJSON(IEnumerable<MyCustomCollection<Otdel>> xxx, string fileName);

    }
}
