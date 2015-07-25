function arrayManipulator(input)
{
    input = input.filter(function (number)
    {
        return !isNaN(number);
    });
    input = input.sort(function (x, y)
    {
        return x < y;
    });
    var mostFrequent;
    var frequency;
    var bestFrequency=0;
    for (var i = 0; i < input.length; i++)
    {
        frequency = 0;
        for (var j = 0; j < input.length; j++)
        {
            if (input[i] === input[j])
            {
                frequency++;
                if (frequency > bestFrequency)
                {
                    bestFrequency = frequency;
                    mostFrequent = input[i];
                }
            }
        }
    }
    var min = Math.min.apply(Math, input);
    var max = Math.max.apply(Math, input);
    console.log('Min number: ' + min);
    console.log('Max number: ' + max);
    console.log('Most frequent number: '+mostFrequent);
    console.log(input);
}
arrayManipulator(["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", {bunniesCount: 10}, [10, 20, 30, 40]]);