String.prototype.startsWith = function (substring) {
    return (this.substring(0, substring.length)) === substring;
};

String.prototype.endsWith = function (substring) {
    return (this.substring(this.length - substring.length, this.length)) === substring;
};

String.prototype.left = function (count) {
    return this.substring(0, count);
};

String.prototype.right = function (count) {
    return this.substring(this.length - count);
};

String.prototype.padLeft = function (count, character) {
    return (character || " ").repeat(count) + this;
};

String.prototype.padRight = function (count, character) {
    return this + (character || " ").repeat(count);
};

String.prototype.repeat = function (count) {
    return Array(count + 1).join(this);
};

var example = "This is an example string used only for demonstration purposes.";
console.log(example.startsWith("This"));
console.log(example.startsWith("this"));
console.log(example.startsWith("other"));

console.log(example.endsWith("poses."));
console.log(example.endsWith("example"));
console.log(example.startsWith("something else"));

console.log(example.left(9));
console.log(example.left(90));

console.log(example.right(9));
console.log(example.right(90));

example = "abcdefgh";
console.log(example.left(5).right(2));

example = "hello";
console.log(example.padLeft(5));
console.log(example.padLeft(10));
console.log(example.padLeft(5, "."));
console.log(example.padLeft(10, "."));
console.log(example.padLeft(2, "."));

console.log(example.padRight(5));
console.log(example.padRight(10));
console.log(example.padRight(5, "."));
console.log(example.padRight(10, "."));
console.log(example.padRight(2, "."));

example = "*";
console.log(example.repeat(5));
console.log("~".repeat(3));
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));