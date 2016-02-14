if (!Object.create) {
    Object.create = function (proto) {
        function F() {
        }

        F.prototype = proto;
        return new F();
    };
}

if (!Object.prototype.extends) {
    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };
}

var Point = (function () {
    function Point(x, y) {
        this._x = x;
        this._y = y;

        return this;
    }

    Point.prototype.toString = function () {
        return 'Point(x:' + this._x + ', y:' + this._y + ')'
    };

    return Point;
})();

var shapesModule = (function () {
    var Shape = (function () {
        function Shape(color) {

            this._color = color;
            return this;
        }

        Shape.prototype.toString = function () {
            return this.constructor.name + ', color: ' + this._color
        };
        return Shape;
    })();

    var Circle = (function () {
        function Circle(centerPoint, radius, color) {
            Shape.call(this, color);
            this._center = centerPoint;
            this._radius = Number(radius);

            return this;
        }

        Circle.extends(Shape);
        Circle.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                ', radius = ' + this._radius +
                ', center: ' + this._center.toString();
        };

        return Circle;
    })();

    var Rectangle = (function () {
        function Rectangle(topLeftPoint, width, height, color) {
            this._topLeft = topLeftPoint;
            this._width = Number(width);
            this._height = Number(height);
            Shape.call(this, color);

            return this;
        }

        Rectangle.extends(Shape);
        Rectangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                ', Top lef corner: ' + this._topLeft +
                ', width: ' + this._width +
                ', height: ' + this._height;
        };

        return Rectangle;
    })();

    var Triangle = (function () {
        function Triangle(pointA, pointB, pointC, color) {
            this._a = pointA;
            this._b = pointB;
            this._c = pointC;
            Shape.call(this, color);

            return this;
        }

        Triangle.extends(Shape);
        Triangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this) + ' ' +
                'A: ' + this._a.toString() + ' ' +
                'B: ' + this._b.toString() + ' ' +
                'C: ' + this._c.toString();
        };

        return Triangle;
    })();

    var Line = (function () {
        function Line(pointA, pointB, color) {
            this._a = pointA;
            this._b = pointB;
            Shape.call(this, color);

            return this;
        }

        Line.extends(Shape);
        Line.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                ', Start = ' + this._a +
                ', End =  ' + this._b;
        };

        return Line;
    })();

    var Segment = (function () {
        function Segment(pointA, pointB, color) {
            this._a = pointA;
            this._b = pointB;
            Shape.call(this, color);

            return this;
        }

        Segment.extends(Shape);
        Segment.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                ', A = ' + this._a +
                ', B = ' + this._b;
        };

        return Segment;
    })();

    return {
        circle: Circle,
        rectangle: Rectangle,
        triangle: Triangle,
        line: Line,
        segment: Segment
    }
})();

var circle = new shapesModule.circle(new Point(3, 5), 12, 'ff0000'),
    rectangle = new shapesModule.rectangle(new Point(10, 20), 20, 15, 'ff00cc'),
    triangle = new shapesModule.triangle(new Point(3, 5), new Point(3, 15), new Point(15, 0), 'e6b800'),
    line = new shapesModule.line(new Point(5, 5), new Point(10, 5), '1a1400'),
    segment = new shapesModule.segment(new Point(5, 5), new Point(10, 5), '1a1400');

console.log(circle.toString());
console.log(rectangle.toString());
console.log(triangle.toString());
console.log(line.toString());
console.log(segment.toString());