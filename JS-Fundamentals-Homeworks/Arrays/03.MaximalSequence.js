function solve(argument) {
    'use strict';

    var input = argument[0];
    var split = input.split('\n');

    var maxLength = 0;
    var currentLength = 0;

    for (var i = 1; i < +split[0] - 1; i += 1) {
        if (+split[i] === +split[i + 1]) {
            currentLength += 1;
            maxLength = Math.max(maxLength, currentLength);
        } else {
            currentLength = 1;
        }
    }

    return maxLength;
}