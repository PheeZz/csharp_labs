using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_3
{
    public class Binary_service<T> : ISettingsService<T> where T : class
    {
        private readonly string _path;

        public Binary_service(string path)
        {
            this._path = path;
        }

        [Obsolete("Obsolete")]
        public T? Read()
        {
            using var stream = new FileStream(_path, FileMode.Open);
            return new BinaryFormatter().Deserialize(stream) as T;
        }

        [Obsolete("Obsolete")]
        public void Update(T item)
        {
            using var stream = new FileStream(_path, FileMode.OpenOrCreate);
            new BinaryFormatter().Serialize(stream, item);
        }
    }
}
