function solve(argument) {
    'use strict';

    var input = argument[0];
    var split = input.split('\n');

    var maxLen = 0;
    var currLen = 1;

    for (var i = 1; i < split.length - 1; i += 1) {
        if (+split[i] < +split[i + 1]) {
            currLen += 1;
            maxLen = Math.max(maxLen, currLen);
        } else {
            currLen = 1;
        }
    }

    return maxLen;
}