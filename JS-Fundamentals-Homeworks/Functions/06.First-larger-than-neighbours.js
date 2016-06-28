function solve(args) {
    'use strict';

    var input = args[0].split('\n');
    var arr = input[1].split(' ').map(Number);

    function firstLarger() {
        for (var i = 1; i < arr.length - 1; i += 1) {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
                return console.log(i);
            }
        }

        return console.log(-1);
    }

    firstLarger();
}