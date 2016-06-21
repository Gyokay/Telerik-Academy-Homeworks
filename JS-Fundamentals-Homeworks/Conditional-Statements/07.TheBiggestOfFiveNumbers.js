function solve(argument) {
    'use strict';

    var a = Number(argument[0]);
    var b = Number(argument[1]);
    var c = Number(argument[2]);
    var d = Number(argument[3]);
    var e = Number(argument[4]);

    var max = a;

    if (max < b) {
        max = b;
    }

    if (max < c) {
        max = c;
    }

    if (max < d) {
        max = d;
    }

    if (max < e) {
        max = e;
    }

    return max;
}