## а)
создать метод расширения для одновременной фильтрации и сортировки произвольного массива (реализовать через делегаты)
<hr>

## б)
Создать класс, который будет генерировать некоторое событие, но при этом будет контроллировать максимальное количетсво подключившихся к событию (число указывается при создании класса). Если подключиться пытается кто-то свыше указаного количества подключений, то он ставится в очередь и будет подключен, когда кто-то отключится от события.</br>
Класс запускается в отдельном потоке
using System.Threading;

// создаем новый поток
Thread myThread = new Thread(ваш_метод);
// запускаем поток myThread
myThread.Start();

и каждые N секунд (N настраивается) генерирует события, а мы к нему подключаем или отключаем обработчики, чтобы продемонстрировать работу