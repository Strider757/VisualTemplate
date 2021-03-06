# VisualTemplate

# Описание:

Создана для облегченного "набивания" конфиги для alpha.server. Возможность сохранить файл-шаблон, для типовых объектов.

# Работа с программой:

Программа работает с шаблоном, по которому строится часть конфигурации. Шаблон должен иметь хотя бы один начальный цикл с которого запускается сборка csv файла для импорта в альфа сервер. Цикл в шаблоне обозначается **[x to y]**, где **x**-начало цикла, **y** - конец цикла. Начальный цикл по умолчанию имеет вид **[1 to 1].** 

Каждый цикл может содержать в себе **переменные**

Каждый раз, при очередном проходе по циклу, переменные увеличивается согласно установленному шагу (**1** - по умолчанию).

так же надо сделать список всех упоминаний переменных в цикле, что бы можно было легко их редактировать, искать и переходить к ним

если переменную нельзя преобразовать в число, то считается, что переменная имеет строковый тип и подставляется без изменений.

Подстановка переменных осуществляется следующим образом:

**$variant$** - где variant имя переменной
Арифметические действия с переменной (если переменная является числом):
**$variant$+x$** - переменная плюс **х
$variant$-x$** - переменная минус **х
$variant$+=x$ -**  значение переменной плюс **х,** с сохранением изменений.
**$variant$-=x$ -**  значение переменной минус **х,** с сохранением изменений.

Существует возможность подставить значение счётчика

**$$** - подставляемое значение счетчика текущего цикла
**$@x$** - подставляемое значение счётчика родительского цикла, где **x** - "поколение" родительского цикла
Арифметические действия со счетчиком:
**$+y$** - счётчик плюс **y**
**$-y$** - счётчик минус **y
$+=y$ -**  значение счётчика плюс **y,** с сохранением изменений

Доступны те же самые действия с родительским счётчиком
**$@x+y$**
**$@x-y$**
**$@x+=y$**

# Заметки

Двойной клик по строчке со списком переменных(справа в верху), во время работы с сигналами копирует в буфер обмена имя переменной со знаками **$**

# Работа набором данных:

Имеется возможность работать с набором данных. Данные необходимо хранить в виде csv файла. CSV файл привязывается к циклу. Начальное и конечное значение цикла игнорируется, так как считается, что одна строка - одно повторение.

Для привязки csv к циклу необходимо добавить его в шаблоне. Затем указать в настройках цикла в строчке **csv.** Далее ****необходимо добавить циклу переменные, где в столбце **Value** указывается заголовок столбца из csv файла с набором данных. Заголовок необходимо заключить в знак процент **%.** При этом имя переменной может быть любым. Для автоматизации данного процесса имеется рядом с выпадающим списком кнопка **updt.**

# Bugs

