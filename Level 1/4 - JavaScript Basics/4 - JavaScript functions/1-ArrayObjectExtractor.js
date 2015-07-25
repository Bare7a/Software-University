function extractObject(input)
{
    var filtered = [];
    input.forEach(function(e)
    {
        if(typeof e === 'object' && !Array.isArray(e))
        {
            filtered.push(e);
        }
    });
    console.log(filtered);
}
extractObject([
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1,2,3],
    "Gosho",
    { name : 'Penka', height: 1.65}
]);