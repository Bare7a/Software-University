function replaceTag(input)
{
    var aReplaced = input.match(/<a [\S][^>]*>/);
    aReplaced[0] = aReplaced[0].replace("<a","[URL");
    aReplaced[0] = aReplaced[0].replace(">","]");
    input = input.replace(/<a [\S][^>]*>/,aReplaced[0]);
    input = input.replace("</a>","[/URL]")
    console.log(input);
}

replaceTag('<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>');