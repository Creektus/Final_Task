# Final_Task

Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

## Описание алгоритма решения:

Задаются два массива: array1 и array2 одинакого размера. Далее создаём метод methodArray, в котором описываем цикл для переменной i перебор значений от 0 и до размера массива array-1. Внутри цикла проверяем условие ( <=3 ). Если условие выполняется, то элемент первого массива заносится в count элемент второго массива. 
Переменная count нужна для того, чтобы присваивать элементы из первого массива во второй. Далее count увеличиваем на 1. И так далее по циклу.