<html>
<head>
    <title>Show Annual Expenses</title>
    <style>
        table, tr, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<form>
    Enter number of years
    <input type="text" name="years">
    <input type="submit" value="Show costs">
</form>
<?php
if (isset($_GET['years'])&&$_GET['years']>0)
{
    echo "<table><tr><td>Year</td><td>January</td><td>February</td><td>March</td><td>April</td><td>May</td><td>June</td><td>July</td><td>August</td><td>September</td><td>October</td><td>November</td><td>December</td><td>Total:</td></tr>";
    $total = 0;
    for ($i = 0; $i < $_GET['years']; $i ++)
    {
        echo "<tr><td>".(2015-$i)."</td>";
        for($j=0;$j<12;$j++)
        {
            $monthlyCost=rand(0,999);
            echo "<td>$monthlyCost</td>";
            $total+=$monthlyCost;
        }
        echo "<td>$total</td></tr>";
        $total = 0;
    }
}
?>
</body>
</html>