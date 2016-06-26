function solve(args) {
    'use strict';

    var input = args[0];

    return ToDigit(input);

    function ToDigit(input) {
        var digits = ['zero', 'one', 'two', 'three', 'four',
            'five', 'six', 'seven', 'eight',
            'nine'];

        return digits[+input[input.length - 1]];
    }
}