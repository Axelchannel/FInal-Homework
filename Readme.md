## Решение задачи
![Блок схема!](Scheme.png) 
_Ccылка_ https://drive.google.com/file/d/1gaL1IatsXcv3XCyLlDUj4cPm3g6N3DM1/view?usp=sharing 

В начале напишем два метода по созданию массива А и его печати на экран для визуального восприятия. 
Массив будет сгенерирован случайным образом из диапазона числе [-10, 10]

После начинаем пробегать по массиву начиная с 0 элемента A[0]

Затем идёт проверка на условие чётности путём деления на 2 без остатка. Если условие выполнено, то запоминаем этот элемент и увеличиваем индекс i. 

Пока длина массива не кончилась, выполняем проверку на чётность. Как только условие не выполнилось, выводим новый массив В, состоящий только из чётных чисел массива А 