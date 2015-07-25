function modifyScore(input)
{
    input = input.filter(function (number)
    {
        return number >= 0 && number <= 400;
    });
    input = input.map(function (number)
    {
            return Math.round((number * 0.8)*10)/10;
    });
    input = input.sort(function (x, y)
    {
        return x > y;
    });
    console.log(input);
}
modifyScore([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);