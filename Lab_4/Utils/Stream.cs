namespace Lab_4;

public class Stream
{
    private readonly int _max_watching;
    private int _already_watching;
    public delegate void handle_message(int i, string message);
    private handle_message? _new_message;
    private readonly Queue<handle_message> _queue = new();

    public Stream(int max_watching)
    {
        _max_watching = max_watching;
        new Thread(() =>
        {
            for (var index = 1; index <= _max_watching; index++)
            {
                send_message(index);
                Thread.Sleep(500);
            }
        }).Start();
    }

    public event handle_message on_new_message
    {
        add
        {
            if (_already_watching <= _max_watching)
            {
                _new_message += value;
                _already_watching++;
            }
            else
            {
                _queue.Enqueue(value);
            }
        }
        remove
        {
            _new_message -= value;
            _already_watching--;
            while (_queue.Count < 0 && _new_message!.GetInvocationList().Length < _max_watching)
            {
                _new_message += _queue.Dequeue();
                _already_watching++;
            }
        }
    }

    private void send_message(int index)
    {
        var messages = new List<string> { "!рулетка", "!anime", "!выбор", "!тайлер", "!бфу", };
        var message = messages[new Random().Next(messages.Count)];
        _new_message?.Invoke(index, message);
    }
}
