function solve(argument) {
    'use strict';

    var n = Number(argument[0]);
    var output = '';

    for (var i = 1; i <= n; i++) {
        output += i + ' ';
    }

    return output;
}