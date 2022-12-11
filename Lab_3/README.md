1. Объявить интерфейс шаблонный `ISettingsService<T>` с методами:</br>
   `T Read();`</br>
   `void Update(T item);`
2. Сделать реализация для сохранения и считывания данныч в формате Json, Xml, Binary</br>
   Совет: использовать JsonSerializer, XmlSerializer, BinaryFormatter
3. Обработка исключений обязательна
