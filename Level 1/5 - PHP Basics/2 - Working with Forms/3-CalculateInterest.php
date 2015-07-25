<?php
header("Content-Type: text/html; charset=UTF-8");
if(isset($_GET['amount'],$_GET['currency'],$_GET['compound'],$_GET['period'])) {
    $amount = (int)$_GET['amount'];
    $currency = htmlentities($_GET['currency']);
    $compound = (int)$_GET['compound'];
    $period = (int)$_GET['period'];
    $interest = ($compound / 12) / 100;
    $total = $amount;
    for ($i = 0; $i < $period; $i++) {
        $total += $total * $interest;
    }
    $total = number_format($total, 2, '.', '');
    $result = "$ " . $total;
}
else
{
    $result ='';
}
?>

<!doctype html>
<html>
<head>
    <title>Calculate Interest</title>
</head>
<body>
<form>
    Enter Ammount <input type="text" name="amount" required="required"/><br/>
    USD<input type="radio" name="currency" value="usd" required="required"/>
    EUR<input type="radio" name="currency" value="eur"/>
    BGN<input type="radio" name="currency" value="bgn"/><br/>
    Compound Interest Amount<input type="text" name="compound"/><br/>
    <select name="period" required="required">
        <option value="6" selected="selected">6 Months</option>
        <option value="12">1 Year</option>
        <option value="24">2 Years</option>
        <option value="60">5 Years</option>
    </select>
    <input type="submit" value="Calculate"/> <?php echo $result; ?>
</form>
</body>
</html>