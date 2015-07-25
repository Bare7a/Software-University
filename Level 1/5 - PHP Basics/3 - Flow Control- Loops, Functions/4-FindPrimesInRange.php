<html>
<head>
    <title>Find Primes In Range</title>
    <style>
        table, tr, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<form>
    Starting index
    <input type="text" name="start">
    End
    <input type="text" name="end">
    <input type="submit" value="Show costs">
</form>
<?php
if (isset($_GET['start']) && isset($_GET['end']) && (int)$_GET['start'] < (int)$_GET['end'])
{
    $start = $_GET['start'];
    $end = $_GET['end'];
    for ($start; $start <= $end; $start++)
    {
        if (isPrimeNumber($start))
        {
            echo "<b>$start</b> ";
        } else
        {
            echo "$start ";
        }
    }
}

function isPrimeNumber($i)
{
    $n = 2;
    while ($n < $i)
    {
        if ($i % $n)
        {
            $n++;
            continue;
        }
        return false;
    }
    return true;
}

?>
</body>
</html>