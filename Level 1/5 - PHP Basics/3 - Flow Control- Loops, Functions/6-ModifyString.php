<html>
<head>
    <title>Sum Of Digits</title>
    <style>
        table, tr, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<form>
    <input type="text" name="input">
    <input type="radio" name="modify" value="palindrome">Check Palindrome
    <input type="radio" name="modify" value="reverse">Reverse String
    <input type="radio" name="modify" value="split">Split
    <input type="radio" name="modify" value="hashify">Hash String
    <input type="radio" name="modify" value="shuffle">Shuffle String
    <input type="submit" value="Submit">
</form>
<?php
if (!empty($_GET['input'])&&isset($_GET['input'],$_GET['modify']))
{
    $string = $_GET['input'];
    switch($_GET['modify'])
    {
        case 'palindrome':
            if($string == strrev($string))
            {
                echo "$string is a palindrome!";
            }
            else
            {
                echo "$string is not a palindrome!";
            }
            ;break;
        case 'reverse': echo strrev($string); break;
        case 'split': echo wordwrap(str_replace(' ','',$string), 1, " ", true);break;
        case 'hashify': echo crypt($string,md5($string)); break;
        case 'shuffle': echo str_shuffle($string);break;
        default: break;
    }
}
?>
</body>
</html>