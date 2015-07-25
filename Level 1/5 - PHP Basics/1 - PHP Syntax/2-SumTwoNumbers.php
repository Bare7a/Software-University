<?php
$firstNumber = 2;
$secondNumber = 5;
printSum($firstNumber, $secondNumber);
$firstNumber = 1.567808;
$secondNumber = 0.356;
printSum($firstNumber, $secondNumber);

function printSum($firstNumber, $secondNumber)
{
    $sum = number_format($firstNumber + $secondNumber, 2);
    echo '$firstNumber + secondNumber = ' . "$firstNumber + $secondNumber = $sum</br>";
}