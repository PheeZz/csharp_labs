using System.Xml.Serialization;

namespace Lab_3
{
    public class Xml_service<T> : ISettingsService<T> where T : class
    {
        private readonly string _path;

        public Xml_service(string path)
        {
            _path = path;
        }

        public T? Read()
        {
            using var stream = new FileStream(_path, FileMode.Open);
            return new XmlSerializer(typeof(T)).Deserialize(stream) as T;
        }

        public void Update(T item)
        {
            using var stream = new FileStream(_path, FileMode.OpenOrCreate);
            new XmlSerializer(typeof(T)).Serialize(stream, item);
        }
    }
}
