# Задача: 
*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*

## Описание решения

1. Задаем строковый массив "text" на старте выполнения алгоритма и выводим его на экран.

2. Выделяем отдельный метод (void) для сборки нового массива, состоящий из элементов заданного размера, который на вход принимает строковый массив и целочисленное значение n, задающее размер элемента массива.

3. В методе задаем новый строковый массив "newText".

4. В цикле
 ~~~ 
 for (int i = 0; i < text.Length; i++)
 ~~~

 проверяем условие, при котором длинна элемента массива не должна превышать n. Если условие выполняется - элемент записывается в новый массив "newText". Если условие не выполняется - переходим к следующему элементу массива.

 5. На выходе получаем новый массив.