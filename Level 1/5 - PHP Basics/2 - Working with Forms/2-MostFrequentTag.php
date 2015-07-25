<!doctype html>
<html>
<head>
    <title>Print Tags</title>
</head>
<body>
Enter Tags: <br/><br/>
<form method="get">
    <input type="text" name="input"/>
    <input type="submit"/>
</form>
<br/>
</body>
</html>
<?php
header("Content-Type: text/html; charset=UTF-8");
if(isset($_GET['input']))
{
    $array = explode(", ", $_GET['input']);
    $arrayCount = [];
    foreach($array as $key=>$value)
    {
        if(isset($arrayCount[$value]))
        {
            $arrayCount[$value]++;
        }
        else
        {
            $arrayCount[htmlentities($value)] = 1;
        }
    }
    arsort($arrayCount);
    foreach($arrayCount as $key=>$value)
    {
        echo "$key : $value times</br>";
    }
    echo "Most Frequent Tag is: ". array_keys($arrayCount)[0];
}
else
{
    echo "Please type something in the input.";
}
?>