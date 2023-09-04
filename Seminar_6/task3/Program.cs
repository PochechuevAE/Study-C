// Работа с классом List

var persons = new List<Person>{ // Создаем базу
    new Person{
        Id = 1,
        Name = "John",
    },
    new Person{
        Id = 2,
        Name = "Alexander",
    },
    new Person{
        Id = 3,
        Name = "Natan",
    },
    new Person{
        Id = 4,
        Name = "Igor",
    },
};
persons.Add(new Person{
        Id = 5,
        Name = "Sahara",
});

System.Console.WriteLine(persons.Where(p => p.Id == 5).FirstOrDefault()?.Name); // Обращаемся к базе 1 элем базы
System.Console.WriteLine(persons[1].Name); // Обращаемся к базе к 1 элем массива


public class Person //записываем свойства
{
    public int Id { get; set;}
    public string Name { get; set; }
}