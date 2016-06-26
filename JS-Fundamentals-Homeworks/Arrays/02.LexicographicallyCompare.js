function solve(argument) {
    'use strict';

    var charArr = argument[0];
    var split = charArr.split('\n');

    if (split[0] === split[1]) {
        return '=';
    } else if (split[0] > split[1]) {
        return '>';
    } else {
        return '<';
    }
}