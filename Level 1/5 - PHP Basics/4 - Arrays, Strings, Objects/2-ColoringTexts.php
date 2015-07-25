<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<html>
<head>
    <title>Coloring Texts</title>
</head>
<body>
<form>
    <textarea name="input"></textarea></br>
    <input type="submit" value="Count words">
</form>
<?php
if (!empty($_GET['input'])&&isset($_GET['input']))
{
    $text = str_split((str_replace(' ','',$_GET['input'])));
    foreach ($text as $char)
    {
        if(ord($char)%2===0)
        {
            echo "<font color ='red'>$char</font> ";
        }
        else
        {
            echo "<font color ='blue'>$char</font> ";
        }
    }
}
?>
</body>
</html>