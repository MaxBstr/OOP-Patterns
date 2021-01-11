# Design OOP Patterns

Design patterns are typical solutions to commonly 
occurring problems in software design.
They are like pre-made blueprints 
that you can customize to solve a recurring design problem in your code.

> + [Creational patterns][create]
> + [Structural patterns][structure]
> + [Behavioral patterns][behave]

[create]: https://github.com/MaxBstr/OOP-Patterns/tree/main/1.%20Creational "Creatonal patterns"
[structure]: https://github.com/MaxBstr/OOP-Patterns/tree/main/2.%20Structural "Structural patterns"
[behave]: https://github.com/MaxBstr/OOP-Patterns/tree/main/3.%20Behavioral "Behavioral patterns"

# Базовые термины ООП
## *В чем идея инкапсуляции? Абстракция, интерфейс и реализация.*

**Интерфейс** – это набор методов класса, доступных для использования другими классами. Интерфейс специфицирует класс, чётко определяя все возможные действия над ним.

**Инкапсуляция** – это свойство системы, позволяющее объединить данные и методы, работающие с ними, в классе и скрыть детали реализации от пользователя.
Инкапсуляция неразрывно связана с понятием интерфейса класса. По сути, всё то, что не входит в интерфейс, инкапсулируется в классе.

**Абстрагирование** – это способ выделить набор значимых характеристик объекта, исключая из рассмотрения незначимые. Соответственно, **абстракция** – это набор всех таких характеристик.

Неверный выбор уровня абстракции ведет к одной из двух *проблем*:
1.	если абстракции **недостаточно**, дальнейшие расширения проекта будут упираться в архитектурные ограничения, которые ведут либо к рефакторингу и смене архитектуры, либо к обилию костылей (оба варианта обычно несут за собой боль и финансовые потери)
2.	если уровень абстракции **слишком высок**, это приведет к оверинжинирингу в виде чересчур сложной архитектуры, которую трудно поддерживать, и излишней гибкости, которая никогда в этом проекте не пригодится. В этой ситуации любые простейшие изменения в проекте будут сопровождаться дополнительной работой для удовлетворения требований архитектуры (это тоже порой несет определенную боль и финансовые потери)

**Композиция** - жизненный цикл дочернего объекта совпадает с жизненным циклом родительского.  
**Агрегация** - жизненный цикл дочернего объекта не зависит от жизненного цикла родительского, и может использоваться другими объектами.

## *В чем идея наследования? Простое, многоуровневое, множественное наследование.*

**Наследование** – это свойство системы, позволяющее описать новый класс на основе существующего с частично или полностью заимствующейся функциональностью.  
Класс, от которого производится наследование, называется базовым или родительским. Новый класс – потомком, наследником или производным классом.  
**Простое наследование** – наследование от 1 родителя
**Множественное наследование** – наследование от 2х и более родителей.

Может возникнуть *ромбовидное* наследование (проблема)  
**Ромбовидная проблема** — прежде всего проблема дизайна, и она должна быть предусмотрена на этапе проектирования. На этапе разработки ее можно разрешить следующим образом:
>	+ вызвать метод конкретного суперкласса;
>	+ обратиться к объекту подкласса как к объекту определенного суперкласса;
>	+ переопределить проблематичный метод в последнем дочернем классе

**Виртуальное наследование** предотвращает появление множественных объектов базового класса в иерархии наследования.  
В **многоуровневом наследовании** производный класс наследует базовый класс, а также производный класс также действует как базовый класс для другого класса.

## *В чем идея полиморфизма? Ранее и позднее (динамическое) связывание.*

**Полиморфизм** – это свойство системы использовать объекты с одинаковым интерфейсом без информации о типе и внутренней структуре объекта.
**Полиморфизм** — возможность объектов с одинаковой спецификацией иметь различную реализацию.  

1. **Раннее связывание** – связанное с формированием кода на этапе компиляции. При раннем связывании программный код формируется на основе известной информации о типе (класса) ссылки. Как правило, это ссылка на базовый класс в иерархии классов.
2. **Позднее связывание** – связанное с формированием кода на этапе выполнения. Если в иерархии классов встречается цепочка виртуальных методов (с помощью слов virtual, override), то компилятор строит так называемое позднее связывание. При позднем связывании вызов метода происходит на основании типа объекта, а не типа ссылки на базовый класс. Позднее связывание используется, если нужно реализовать полиморфизм.

Выбор того или иного вида связывания для каждого отдельного элемента (метода, свойства, индексатора и т. п.) определяется компилятором по следующим правилам:
> + если в иерархии унаследованных классов объявляется невиртуальный элемент, то реализуется раннее связывание;
> + если в иерархии унаследованных классов объявляется виртуальный элемент, то выполняется позднее связывание.  
Виртуальный элемент в базовом классе обозначается ключевым словом virtual, во всех унаследованных классах ключевым словом override.

![Пример](https://www.bestprog.net/wp-content/uploads/2020/04/02_02_02_11_09_01r.jpg "Example")

Главный **принцип** *полиморфизма* – один интерфейс, много реализаций (методов). 
В терминах языка программирования **полиморфизм** – это возможность с помощью ссылки на базовый класс обращаться к элементам (методов) экземпляров унаследованных классов единым унифицированным способом.
В языке программирования C# полиморфизм обеспечивается с помощью ключевых слов virtual и override. Благодаря использованию этих ключевых слов обеспечивается динамический полиморфизм. 
Термин «динамический» означает, что вызов виртуального элемента осуществляется динамично во время выполнения программы в зависимости от типа объекта, для которого этот элемент вызывается.

Полиморфизм можно применять для следующих элементов:
> + методов;
> +	свойств;
> + индексаторов;
> + событий.

## *GRASP Patterns*

**Informational Expert**: ответственность должен брать на себя тот, кто обладает максимумом информации для исполнения.
Если класс – «эксперт» над какими-нибудь данными, то методы для обработки этих данных должны быть в этом классе.

**Low coupling**: классы (модули) должны знать как можно меньше информации друг о друге
Минусы сильной связности:
> + Затрудняется понимание логики модулей
> + Сложная модификация программы
> + Проблемы с тестированием
> + Невозможность переиспользования отдельного модуля

**High cohesion**: ответственность модуля должна быть сосредоточена в одной области.  
Простыми словами конкретный модуль описывает всю бизнес-логику определенного приложения, другие модули только используют его.

**Controller** – принимает запрос и делегирует работу функциям.

**Creator** – создавать объекты должен тот класс, который преимущественно их использует.  
Сочетается с Informational Expert и Low coupling (знать об объектах должен тот, кто их использует).  
Противоречит DI (Dependency Injection) при которой многие объекты создаются на этапе старта приложения, а потом с помощью DI механизма “внедряются” друг в друга.

**Pure Fabrication** – создание объекта, не отражающего никакую сущность доменной области, а нужный лишь для уменьшения связности, усиления зацепления и легкости переиспользования.  
Пример: ORM

**Indirection** – реализация низкой связности между классами, путем назначения обязанностей по их взаимодействию дополнительному объекту – посреднику.  
Пример: Controller из MVC  

**Protected Variations** – выделение точек неустойчивости, которые часто подвержены изменению или модификации, в виде интерфейсов.  
Пример: добавление новых тарифов, базовый тариф сделаем интерфейсом.

## *SOLID Patterns*

**S – Single of Responsibility**: Каждый модуль (класс) должен быть ответственен за единственную задачу.  
Может иметь несколько методов, но они используются только для решения 1 задачи.

**O – Open Closed**: Система должна быть открыта для расширения, но не для модификации.  
Используется полиморфизм, то есть расширение через новую имплементацию интерфейса либо через расширение интерфейса
Коррелирует с Polymorphism и Protected Variations

**L – Liskov Substitution**: Наследующий класс должен дополнять, а не замещать поведение базового класса. 
Производный класс должен быть взаимозаменяем с базовым классом.
Условия:
> 1. Предварительные условия не могут быть усилены в подтипе
> 2. Постусловия не могут быть ослаблены в подтипе 
> 3. Инварианты супертипа должны быть сохранены в подтипе.  
Клиент не должен знать, использует ли он базовый класс или какой-то из его подтипов (поведение должно быть ожидаемым)

**I – Interface Segregation**: Много небольших интерфейсов лучше, чем один большой.  
Не стоит заставлять клиента реализовывать ненужный ему интерфейс.  
**D – Dependency Inversion**: Зависимости строятся на абстракциях.  
Модули более высоких уровней (бизнес-логики) не должны зависеть от модулей более низких уровней (ввод-вывод).  
Детали должны зависеть от абстракций, а не наоборот.

