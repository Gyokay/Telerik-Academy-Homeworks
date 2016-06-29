function solve(args) {
    'use strict';

    let str = args[0];

    let output = '';

    for (let i = str.length - 1; i >= 0; i -= 1) {
        output += str[i];
    }

    console.log(output);
}