# Решение контрольной задачи

## Поставнока задачи

*Написать программу, которая из имеющегося массива строк формирует массив строк,*
*длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,*
*либо задать на старте выполнения алгоритма.*

## Уточнение ввода исходных данных

В данной задаче решено реализовать ввод исходного массива строк с клавиатуры.

## Поэтапное решение задачи

1. Вывод на экран сообщения для ввода данных.
2. Создание метода проверки введеных данных на значение NULL.
И сепарация данных в массив строк методом Split. В качестве разделителя выбран пробел. Все остальные символы 
будут добавлены к нашим строкам.
3.Подсчет количества элементов нашего массива с длиной меньше либо равной 3.
4.Инициализация итогового массива строк с количеством элементов с числом тз пункта 3. 
5.Добавление элементов из первого массива, удовлетворяющих условию <= 3 элемента, во второй массив.
6. Вывод на экран итогового массива.
