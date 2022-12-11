namespace Lab_3
{
    public interface ISettingsService<T>
    {
        T? Read();
        void Update(T item);
    }
}
