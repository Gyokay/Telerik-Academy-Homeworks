function solve(argument) {
    'use strict';

    var input = argument[0];
    var output = '';
    
    !function sayHello() {
        output = 'Hello, ' + input + '!';
        console.log(output);
    }();
}