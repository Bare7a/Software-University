<html>
<head>
    <title>Square Root Sum</title>
    <style>
        table,tr,td
        {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <table>
        <tr>
            <td><b>Number</b></td><td><b>Square</b></td>
        </tr>
        <?php
        $squareRootSum = 0;
        for($i=0;$i<=100;$i+=2)
        {
            $squareRoot = (float)number_format(sqrt($i),2)+0;
            echo "<tr><td>$i</td><td/>$squareRoot</tr>";
            $squareRootSum += $squareRoot;
        }
        echo "<tr><td><b>Total</b></td><td>$squareRootSum</td></tr>";
        ?>
    </table>
</body>
</html>