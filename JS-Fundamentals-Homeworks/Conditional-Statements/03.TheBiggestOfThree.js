function solve(argument) {
    'use strict';

    var a = Number(argument[0]);
    var b = Number(argument[1]);
    var c = Number(argument[2]);

    if (a >= b) {
        if (a >= c) {
            return a;
        } else if (c >= a) {
            return c;
        }
    } else if (b >= a) {
        if (b >= c) {
            return b;
        } else if (b <= c) {
            return c;
        }
    }
}