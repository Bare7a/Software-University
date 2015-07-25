"use strict";
function quadraticEquation(a,b,c)
{
    var d = parseInt(b*b-4*a*c);
    if(d<0)
    {
        console.log('No real roots');
    }
    else if(d===0)
    {
        console.log('X = '+(-b/(2*a)))
    }
    else
    {
        console.log('X1 = '+((-b-Math.sqrt(d))/(2*a)));
        console.log('X2 = '+((-b+Math.sqrt(d))/(2*a)));
    }
}
quadraticEquation(2,5,-3);
quadraticEquation(2,-4,2);
quadraticEquation(4,2,1);