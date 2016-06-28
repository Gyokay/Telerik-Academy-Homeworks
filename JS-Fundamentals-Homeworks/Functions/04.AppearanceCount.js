function solve(args) {
    'use strict';

    var input = args[0].split('\n'),
        n = +input[0],
        arr = input[1].split(' ').map(Number),
        x = +input[2],
        count = 0;

    function countAppearance(arr, x) {
        for (var i = 0; i < n; i += 1) {
            if (arr[i] === x) {
                count += 1;
            }
        }

        return count;
    }

    return countAppearance(arr, x);
}