Array.prototype.flatten = function () {
    var result = [];

    function flatten(elements, output) {
        elements.forEach(function (element) {
            if (!(typeof element === 'object' || typeof element === typeof Array)) {
                output.push(element);
            }
            else {
                flatten(element, output);
            }
        });
    }

    flatten(this, result);
    return result;
};

var array = [1, 2, 3, 4];
console.log(array.flatten());

array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());
console.log(array);

array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());