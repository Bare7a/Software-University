var validateButton = document.getElementsByTagName('button')[0];
validateButton.addEventListener('click',function()
{
    var input = document.getElementById('input');
    var text = input.value;

    var output = document.getElementById('output');
    output.innerText = text;

    var isValidEmail = validateEmail(text);

    if (isValidEmail)
    {
        output.style.backgroundColor = 'green';
    }
    else
    {
        output.style.backgroundColor = 'red';
    }
});

function validateEmail(email)
{
    var result = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
    //var result = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    return result.test(email);
}
