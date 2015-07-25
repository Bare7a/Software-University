<?php
$var = true;
isNumeric($var);
$var = 'Hello!';
isNumeric($var);
$var = 3.14;
isNumeric($var);
$var = 8;
isNumeric($var);

function isNumeric($var)
{
    if (is_numeric($var))
    {
        var_dump($var);
    }
    else
    {
        echo gettype($var) . "</br>";
    }
}