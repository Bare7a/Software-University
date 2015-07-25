<?php
isNotRepeating(145);
isNotRepeating(15);
function isNotRepeating($number)
{
    $result = '';
    for ($i = 100; $i <= $number; $i++)
    {
        if ((int)($i % 10) != (int)($i / 10 % 10) && (int)($i / 10 % 10) != (int)($i / 100) && (int)($i % 10) != (int)($i / 100))
        {
            $result .= $i . ', ';
        }
    }
    if ($result == '')
    {
        echo "no</br>";
    }
    else
    {
        $result = substr($result, 0, -2);
        echo $result . "</br>";
    }
}