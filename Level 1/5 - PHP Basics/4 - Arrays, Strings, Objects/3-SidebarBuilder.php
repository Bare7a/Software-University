<?php
header("Content-Type: text/html; charset=utf-8");
mb_internal_encoding("utf-8");
?>
<html>
<head>
    <title>Sidebar Builder</title>
    <style>
        #nav
        {
            border: 1px solid black;
            border-radius: 20px;
            width: 200px;
            background-color: cyan;
            margin-bottom: 10px;
        }
        #nav>ul
        {
            list-style: circle;
        }
        #nav>ul>li
        {
            text-decoration: underline;
        }
    </style>
</head>
<body>
<form>
    Categories: <input type="text" name="categories"></br>
    Tags: <input type="text" name="tags"></br>
    Months: <input type="text" name="months">
    <input type="submit" value="Generate">
</form>
<?php
if (!empty($_GET['categories'])&&isset($_GET['categories']))
{
    $categories = explode(', ',$_GET['categories']);
    echo "<div id='nav'><h1>Categories</h1><ul>";
    foreach ($categories as $word)
    {
        echo "<li>".htmlentities($word)."</li>";
    }
    echo "</ul></div>";
}
if (!empty($_GET['tags'])&&isset($_GET['tags']))
{
    $tags = explode(', ',$_GET['tags']);
    echo "<div id='nav'><h1>Tags</h1><ul>";
    foreach ($tags as $word)
    {
        echo "<li>".htmlentities($word)."</li>";
    }
    echo "</ul></div>";
}
if (!empty($_GET['months'])&&isset($_GET['months']))
{
    $months = explode(', ',$_GET['months']);
    echo "<div id='nav'><h1>Months</h1><ul>";
    foreach ($months as $word)
    {
        echo "<li>".htmlentities($word)."</li>";
    }
    echo "</ul></div>";
}
?>
</body>
</html>