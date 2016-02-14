var checkBox = document.getElementById('checkBox');

checkBox.addEventListener('click', function(e)
{
    var additionalForm = document.getElementById('additionalForm');

    if (e.target.checked)
    {
        additionalForm.removeAttribute('hidden');
    } else
    {
        additionalForm.setAttribute('hidden','hidden');
    }
});