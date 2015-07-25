function DecToHex(dec)
{
    //var dec = prompt('Enter a number');
    var hex = "";
    while (dec != 0)
    {
        switch (dec % 16)
        {
            case 10:
                hex = "A" + hex;
                break;
            case 11:
                hex = "B" + hex;
                break;
            case 12:
                hex = "C" + hex;
                break;
            case 13:
                hex = "D" + hex;
                break;
            case 14:
                hex = "E" + hex;
                break;
            case 15:
                hex = "F" + hex;
                break;
            default :
                hex = dec % 16 + hex;
                break;
        }
        dec = parseInt(dec / 16);
    }
    alert(hex);
}