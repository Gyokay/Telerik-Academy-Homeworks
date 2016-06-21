function solve(argument) {
    'use strict';

    var a = Number(argument[0]);
    var b = Number(argument[1]);
    var c = Number(argument[2]);
    var d = b * b - 4 * a * c;

    if (d < 0) {
        return 'no real roots';
    } else if (d === 0) {
        return "x1=x2=" + (-b / (2 * a)).toFixed(2);
    } else {
        return "x1=" + ((-b - Math.sqrt(d)) / (2 * a)).toFixed(2) + "; x2=" + ((-b + Math.sqrt(d)) / (2 * a)).toFixed(2);
    }

}