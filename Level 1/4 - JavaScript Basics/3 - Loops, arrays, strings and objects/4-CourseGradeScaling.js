function scaleGrade(input)
{
    /*input = input.filter(function(score){
     return score>100;
     });*/
    //console.log(input);
    input.map(function (e)
    {
        e.score *= 1.1;
        e.score = parseFloat(e.score.toFixed(1));
        if(e.score >= 100) {
            e.hasPassed = true;
        } else {
            e.hasPassed = false;
        }
    });

    input.sort (function(x, y) {return x.name > y.name});

    input.forEach(function (e)
    {
        if(e.hasPassed)
        {
            console.log(e);
        }
    })

}

scaleGrade([
    {
        'name': 'Пешо',
        'score': 91
    },
    {
        'name': 'Лилия',
        'score': 290
    },
    {
        'name': 'Алекс',
        'score': 343
    },
    {
        'name': 'Габриела',
        'score': 400
    },
    {
        'name': 'Жичка',
        'score': 70
    }
]);