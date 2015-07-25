function clock()
{
    setTimeout("clock()", 1000);
    var time = "<p>" + new Date().getHours() + ":" + new Date().getMinutes() + ":" + new Date().getSeconds() + "</p>";
    document.getElementById("time").innerHTML = time;
}