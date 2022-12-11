using System.Text.Json;

namespace Lab_3
{
    public class Json_service<T> : ISettingsService<T> where T : class
    {
        private readonly string _path;

        public Json_service(string path)
        {
            _path = path;
        }

        public T? Read() => JsonSerializer.Deserialize<T>(File.ReadAllText(_path));

        public void Update(T item) => File.WriteAllText(_path, JsonSerializer.Serialize(item));
    }
}
