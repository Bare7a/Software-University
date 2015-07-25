"use strict";
function calculateKnots(kmh)
{
        var knots = (kmh/1.852).toFixed(2);
        console.log(knots);
}
calculateKnots(20);
calculateKnots(112);
calculateKnots(400);