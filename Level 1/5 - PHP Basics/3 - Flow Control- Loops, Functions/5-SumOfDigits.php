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
    Input string:
    <input type="text" name="input">
    <input type="submit" value="Submit">
</form>
<?php
if (!empty($_GET['input'])&&isset($_GET['input']))
{
    echo "<table>";
    $array = explode(', ',$_GET['input']);
    foreach($array as $element)
    {
        if((int)$element)
        {
            $count = 0;
            for ($i = 0; $i < strlen($element); ++$i)
            {
                $count += $element[$i];
            }
            echo "<tr><td>$element</td><td>$count</td></tr>";
        }
        else
        {
            echo "<tr><td>$element</td><td>I cannot sum that</td></tr>";
        }
    }
    echo "</table>";
}
?>
</body>
</html>