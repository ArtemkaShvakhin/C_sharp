using System;

namespace Firma
{
    public class Serializer: ISerializer
    {
        public Serializer() { }
        IEnumerable<ССС> DeSerializeByLINQ(string fileName);
        IEnumerable<ССС> DeSerializeXML(string fileName);
        IEnumerable<ССС> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<ССС> xxx, string fileName);
        void SerializeXML(IEnumerable<ССС> xxx, string fileName);
        void SerializeJSON(IEnumerable<ССС> xxx, string fileName);

    }
}
