function findYoungestPerson(people)
{
    var age = 200;
    var index;
    for (var i = 0; i < people.length - 1; i++)
    {
        if (people[i].hasSmartphone && people[i].age < age)
        {
            age = people[i].age;
            index = i;
        }
    }
    console.log(people[index]);
}
var people = [
    {firstname: 'George', lastname: 'Kolev', age: 32, hasSmartphone: false},
    {firstname: 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true},
    {firstname: 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true},
    {firstname: 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false}];
findYoungestPerson(people);