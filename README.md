Немного пояснения к коду.
Основные методы классов Circle и Triangle - это Area в этом методе происходит рассчет площади фигур. Я сделал возвращаемое значение string в целях обезопашивания кода от отрицательных чисел, как вывести значение или ошибку вне зависимости от приложения(Консольное или десктопное) в виду того я не знаю ни одного метода вернуть и число и строку.

#Ответ на задание по снаписанию SQL запроса#

use "имя БД"
select * 
from товар
left join категория on товар.id_категории = категория.id_категории