if (!Object.prototype.extends) {
    Object.prototype.extends = function (properties) {
        function F() {
        }

        F.prototype = Object.create(this);
        for (var prop in properties) {
            F.prototype[prop] = properties[prop];
        }
        F.prototype._super = this;
        return new F();
    };
}

var Point = {
    init: function (x, y) {
        this._x = x;
        this._y = y;
        return this;
    },
    toString: function () {
        return 'Point(' + 'x = ' + this._x + ', y = ' + this._y + ')'
    }
};

var shapeModule = (function () {
    var Shape = {
        init: function init(color) {
            this._color = color;
            return this;
        },
        toString: function () {
            return 'color = ' + this._color;
        }
    };

    var Circle = Shape.extends({
        init: function init(color, center, radius) {
            this._super.init.call(this, color);
            this._center = center;
            this._radius = radius;

            return this;
        },
        toString: function () {
            return 'Circle: ' + this._super.toString.call(this) +
                ', center = ' + this._center.toString() +
                ', radius = ' + this._radius;
        }
    });


    var Rectangle = Shape.extends({
        init: function init(color, topLeftPoint, width, height) {
            this._topLeft = topLeftPoint;
            this._width = width;
            this._height = height;
            this._super.init.call(this, color);

            return this;
        },
        toString: function () {
            return 'Rectangle: ' + this._super.toString.call(this) +
                ', topLeftPoint = ' + this._topLeft.toString() +
                ', width = ' + this._width +
                ', height = ' + this._height;
        }
    });

    var Triangle = Shape.extends({
        init: function init(color, pointA, pointB, pointC) {
            this._pointA = pointA;
            this._pointB = pointB;
            this._pointC = pointC;
            this._super.init.call(this, color);

            return this;
        },
        toString: function () {
            return 'Triangle: ' + this._super.toString.call(this) +
                ', A = ' + this._pointA.toString() +
                ', B = ' + this._pointB.toString() +
                ', C = ' + this._pointC.toString();
        }
    });

    var Line = Shape.extends({
        init: function init(color, pointA, pointB) {
            this._pointA = pointA;
            this._pointB = pointB;
            this._super.init.call(this, color);

            return this;
        },
        toString: function () {
            return 'Line: ' + this._super.toString.call(this) +
                ', Start = ' + this._pointA.toString() +
                ', End = ' + this._pointB.toString();
        }
    });

    var Segment = Shape.extends({
        init: function init(color, pointA, pointB) {
            this._pointA = pointA;
            this._pointB = pointB;
            this._super.init.call(this, color);

            return this;
        },
        toString: function () {
            return 'Segment: ' + this._super.toString.call(this) +
                ', Start = ' + this._pointA.toString() +
                ', End = ' + this._pointB.toString();
        }
    });

    return {
        line: Line,
        circle: Circle,
        rectangle: Rectangle,
        triangle: Triangle,
        segment: Segment
    }
})();

var circle = shapeModule.circle.init('green', Point.init(5, 10), 25);
var rectangle = shapeModule.rectangle.init('white', Point.init(10, 20), 30, 50.5);
var triangle = shapeModule.triangle.init('pink', Point.init(5, 0), Point.init(10, 0), Point.init(7.5, 12.175));
var line = shapeModule.line.init('blue', Point.init(4, 6), Point.init(10, 15));
var segment = shapeModule.segment.init('brown', Point.init(12.7, 6.78), Point.init(155, -37));

console.log(circle.toString());
console.log(rectangle.toString());
console.log(triangle.toString());
console.log(line.toString());
console.log(segment.toString());