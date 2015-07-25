function sortLetters(word, boolean)
{
    word = word.split('').sort(function (x, y)
    {
        if (boolean)
        {
            return x.toLowerCase() > y.toLowerCase();
        }
        else
        {
            return x.toLowerCase() < y.toLowerCase();
        }
    }).join('');
    console.log(word);
}
sortLetters('HelloWorld', true);
sortLetters('HelloWorld', false);