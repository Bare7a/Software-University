<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<html>
<head>
    <title>Text Filter</title>
    <style>
        textarea
        {
            width: 500px;
            height: 200px;
        }
        input[type='text']
        {
            width: 500px;
        }
    </style>
</head>
<body>
<form>
    Input text:</br>
    <textarea name="input"></textarea></br>
    Banlist: </br>
    <input type="text" name="banlist"/></br>
    <input type="submit" value="Filter Text">
</form>
<?php
if (!empty($_GET['input'])&&isset($_GET['input']))
{
    $text = $_GET['input'];
    if(!empty($_GET['banlist'])&&isset($_GET['banlist']))
    {
        $banlist = explode(', ',$_GET['banlist']);
        foreach($banlist as $word)
        {
            $replacement = str_repeat('*', strlen($word));
            $text = str_replace($word, $replacement, $text);
        }
        $text = htmlentities($text);
        echo "<textarea>$text</textarea>";
    }
    else
    {
        $text = htmlentities($text);
        echo "<textarea>$text</textarea>";
    }
}
?>
</body>
</html>