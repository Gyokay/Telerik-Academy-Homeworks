function solve(argument) {
    'use strict';

    var a = Number(argument[0]);
    var b = Number(argument[1]);

    var output = '';

    if (a > b) {
        output = String(b) + ' ' + String(a);
    } else {
        output = String(a) + ' ' + String(b);
    }

    return output;
}