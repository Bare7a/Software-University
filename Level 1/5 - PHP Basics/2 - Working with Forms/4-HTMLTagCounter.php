<html>
<head>
    <meta>
    <title>HTML Tag Counter</title>
</head>
<body>
Enter HTML Tags:<br/><br/>
<form>
    <input type="text" name="input"/>
    <input type="submit"/>
</form>
</body>
</html>
<?php
session_start();
if(!isset($_SESSION['score']))
{
    $_SESSION['score'] = 0;
}
$validTags = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
    'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
    'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
    'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
    'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
    'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
    'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
    'tt', 'u', 'ul', 'var');
    if(isset($_GET['input']))
    {
        $input = htmlentities($_GET['input']);
        if(in_array($input,$validTags))
        {
            $_SESSION['score']++;
            echo "<h1>Valid HTML tag!<br/>Score:". $_SESSION['score']."</h1>";
        }
        else
        {
            echo "<h1>Invalid HTML tag!<br/>Score:".$_SESSION['score']."</h1>";
            unset($_SESSION['score']);
            session_unset();
        }
    }