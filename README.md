# BeautifuNumbersCount

Будем описывать однозначные числа производящим многочленом $$A_1(s) = 1 + s + s^2 + . . . + s^{13-1}.$$
Смысл у этого многочлена следующий: коэффициент при $s_n$ в многочлене $A_1$ равен числу однозначных, сумма цифр которых равна n. 
Найдем количество всевозможных сумм на первых 6 местах: $$A_6(s) = (A_1(s))^6.$$ Коэффициентами в данном случае являются числа, равные количеству шестизначных чисел,
сумма которых равна степени одночлена, при котором стоит этот коэффициент. На последних шести разрядах 13-ти значного числа возможны такие же варианты расположения,
как и на первых шести. Всевозможные варианты находим по правилу произведения - перемножаем коэффициенты многочлена, которые стоят при одинаковых степенях. Поскольку
посередине (7-й разряд) может стоять любое число от 0 до 12, то умножаем еще на 13.

Ответ: 9203637295151
