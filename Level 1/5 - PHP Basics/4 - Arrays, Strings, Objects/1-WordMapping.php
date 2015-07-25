<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<html>
<head>
    <title>Word Mapping</title>
    <style>
        table,tr,td
        {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<form>
    <textarea name="input"></textarea></br>
    <input type="submit" value="Count words">
</form>
    <?php
    if (!empty($_GET['input'])&&isset($_GET['input']))
    {
        $array = preg_split('/[^a-zA-Z]+/',strtolower($_GET['input']),-1,PREG_SPLIT_NO_EMPTY);
        if(!empty($array))
        {
            $countWords = [];
            foreach ($array as $word)
            {
                if (!isset($countWords[htmlentities($word)]))
                {
                    $countWords[htmlentities($word)] = 1;
                } else
                {
                    $countWords[htmlentities($word)]++;
                }
            }
            echo '<table>';
            foreach ($countWords as $word => $count)
            {
                echo "<tr><td>$word</td><td>$count</td></tr>";
            }
            echo '</table>';
        }
        unset($_GET['input']);
    }
    ?>
</body>
</html>