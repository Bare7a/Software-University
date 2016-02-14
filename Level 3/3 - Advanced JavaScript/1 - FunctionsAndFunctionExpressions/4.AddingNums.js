var add = (function(){
    var sum = 0;

    function increment(number){
        sum+=number;
        return increment;
    }

    increment.toString = function(){
        return sum;
    };

    return increment;
})();

var addTwo = add(2);

console.log(addTwo.toString());
console.log(addTwo(3).toString());
console.log(addTwo(4)(5).toString());