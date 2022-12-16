## Все задания решать при помощи LINQ

1. Создать

```
Record Person(string FirstName,
string SecondName,
DateTime DateOfBirth,
Gender(Enum) Gender,
List<string> Languages,
Occupation Enum) Occupation)
```

Создайте массив не менее, чем из 15 объектов Person. Написать функцию фильтрации:

```
ApplyFilter(string? firstName = null,
string? secondName = null,
DateTime? startDate = null,
DateTime? endDate = null,
Gender? gender = null,
List<string>? languages = null,
List<Occupation>? occupations = null)
```

В случае, если какой-то из параметров функции = null, это означает, что фильтр не применяется.

По параметрам `firstName, secondName` поиск производится по соответствию LIKE

1.  Создайте класс `Car` со свойствами `Model, Producer, RegNumber, Color, Price,
YearOfCreate`. Создайте массив из не менее чем 15 машин. Сгруппируйте машины по
    производителю, посчитайте их количество в каждой группе, вычислите средний год производства
2.  Будем считать, что машины, произведенные до 2010 рухлядь, до 2015 старые, до 2019 сойдет,
    после 2019- новые. Посчитать число машин в каждой группе, для каждой группы сформировать
    список машин
3.  Создать класс
    ```
    Category(Id, Name),
    Manufactory(Id, Name, Country),
    Product(Id, CategoryId, ManufactoryId, Name, Amount, ItemPrice).
    ```
    Создать список из 3 категорий, 5 производителей, и не менее 20 продуктов. Построить функции:
    отбора всех продуктов по названию категории, по названию производителя, с цене менее 10000,
    тех что есть в наличие (`amount>0`). Посчитать среднюю цену продукта в целом, по категории, по
    производителю, по категории и производителю.
