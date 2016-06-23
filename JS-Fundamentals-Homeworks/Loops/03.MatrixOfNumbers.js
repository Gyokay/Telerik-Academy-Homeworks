function solve(params) {
    'use strict';

    var n = +params[0];
    var result = '';
    var num = 1;

    for (var i = 0; i < n; i += 1) {
        for (var j = 0; j < n; j += 1){
            result += num + ' ';
            num += 1;
        }

        num -= n - 1;
        console.log(result);
        result = '';
    }
    
}