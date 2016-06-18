function solve(argument) {
    'use strict';

    var a = Number(argument[0]);
    var b = Number(argument[1]);
    var c = Number(argument[2]);

    if (a === 0 || b === 0 || c === 0) {
        return '0';
    } else if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0)) {
        return '-';
    } else if (a < 0 && b < 0 && c < 0) {
        return '-';
    } else {
        return '+';
    }
}