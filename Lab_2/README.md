## Задание номер 4:

Реализовать классы:

<ul>
    <li>House</li>
    <li>Basement</li>
    <li>Walls</li>
    <li>Door</li>
    <li>Window</li>
    <li>Roof</li>
    <li>Worker</li>
    <li>TeamLeader</li>
    <li>Team</li>
</ul>

И интерфейсы:

<ul>
<li>IWorker</li>
<li>IPart</li>
</ul>

Все части дома должны реализовать интерфейс **IPart**.</br>
Для рабочих и бригадира предоставляется базовый интерфейс **IWorker**</br>
Бригада строителей (*Team*) строит дом (*House*). Дом состоит из фундамента (*Basement*), стен (*Wall*), окон (*Window*), дверей (*Door*), крыши (*Roof*).</br>
Согласно проекту, в доме должно быть:

<ul>
<li>1 фундамент</li>
<li>4 стены</li>
<li>1 дверь</li>
<li>4 окна</li>
<li>1 крыша</li>
</ul>

Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента. Каждый строитель не знает заранее, на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что уже построено и продолжает работу. Если в игру вступает бригадир (*TeamLeader*), он не строит, а формирует отчёт, что уже построено и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома” (циклами).