# Библиотека для вычисления математических операций (тестовый проект)

Эта библиотека предоставляет набор математических плагинов для различных операций, включая сложение, вычитание, умножение, деление и вычисление процентов.

## Установка

Для использования этой библиотеки в вашем проекте, вы можете воспользоваться NuGet:

```bash
nuget install ds.test.impl 
```

### Использование
Для начала использования библиотеки вам нужно подключить ее в вашем коде и создать экземпляры плагинов. 

#### Плагин для сложения (AdditionPlugin)
```csharp
using ds.test.impl;

// Создание экземпляра плагина для сложения
var additionPlugin = new AdditionPlugin();
int sum = additionPlugin.Run(3, 5);
```

#### Плагин для вычитания (SubtractionPlugin)
```csharp
using ds.test.impl;

// Создание экземпляра плагина для вычитания
var subtractionPlugin = new SubtractionPlugin();
int difference = subtractionPlugin.Run(8, 3);
```
#### Плагин для умножения (MultiplicationPlugin)
```csharp
using ds.test.impl;

// Создание экземпляра плагина для умножения
var multiplicationPlugin = new MultiplicationPlugin();
int product = multiplicationPlugin.Run(4, 6);
```
#### Плагин для деления (DivisionPlugin)
```csharp
using ds.test.impl;

// Создание экземпляра плагина для деления
var divisionPlugin = new DivisionPlugin();
int quotient = divisionPlugin.Run(12, 3);
```
#### Плагин для вычисления процентов (PercentagePlugin)
```csharp
using ds.test.impl;

// Создание экземпляра плагина для вычисления процентов
var percentagePlugin = new PercentagePlugin();
int percentage = percentagePlugin.Run(50, 20);
```
### Доступные плагины
AdditionPlugin: Выполняет сложение.
SubtractionPlugin: Выполняет вычитание.
MultiplicationPlugin: Выполняет умножение.
DivisionPlugin: Выполняет деление. Обратите внимание, что этот плагин вызывает исключение при попытке деления на ноль.
PercentagePlugin: Вычисляет проценты. Этот плагин также вызывает исключение при попытке деления на ноль.

### Зависимости
Эта библиотека не имеет внешних зависимостей и может быть легко интегрирована в ваши проекты.
