using _001Task;
using _001Task.Data;
using System.Runtime.Intrinsics.X86;

await using var dataContext = new DataContext();


Console.WriteLine(" Good look 😊😊😊 ");

//1
//Напишите запрос LINQ, чтобы получить всех людей, живущих в городе с населением более 3 человек.
//Write a LINQ query to retrieve all the people who live in a city with a population greater than 3 

//var person = from e in 
//             where 
//2
//Получите все города со средней численностью населения в соответствующей стране
//Retrieve all cities with their respective country's average population

//3
//Получите города с самым высоким населением в каждой стране
//Retrieve the cities with the highest population in each country

//4
//Получите среднее население городов в каждой стране
//Retrieve the average population of cities in each country

//5
//Получить все города, в которых есть человек по имени "Марк".
//Retrieve all cities that have a person with by name "Mark"


//6
//Получить всех людей вместе с соответствующими названиями городов и стран
//Retrieve all people along with their associated city and country names

//7
//Получите все города вместе с соответствующими названиями стран, используя свойство навигации
//Retrieve all cities along with their associated country names using a navigation property

//8
//Получить всех людей вместе с связанными с ними городом и страной.
//Retrieve all people along with their associated city and country 

//9
//Получить всех людей, живущих в "USA".
//Retrieve all people living in  "USA".

var person = from e in dataContext.Countries
             join c in dataContext.Cities on e.Id equals c.CountryId
             join p in dataContext.Peoples on c.Id equals p.CityId
             where e.Name == "USA"
             select p;
foreach (var e in person) Console.WriteLine(e.FirstName);
//10
//Получить всех людей вместе с соответствующим населением города и страны
//Retrieve all people along with their associated city and country populations 





