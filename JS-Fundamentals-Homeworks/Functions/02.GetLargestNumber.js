function solve(args) {
    'use strict';

    var input = args[0].split(' ');

    return GetMax(+input[0], GetMax(+input[1], +input[2]));

    function GetMax(a, b) {
       if (a < b) {
           return b;
       } else if (a > b) {
           return a;
       }
        return a;
    }
}