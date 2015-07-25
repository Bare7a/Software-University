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
        foreach ($array as $key=>$value)
        {
            echo "$key : ".htmlentities($value)."<br/>";
        }

    }
    else
    {
        echo "Please type something in the input.";
    }
?>