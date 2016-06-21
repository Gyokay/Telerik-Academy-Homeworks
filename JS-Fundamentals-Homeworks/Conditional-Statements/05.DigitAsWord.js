function solve(argument) {
    'use strict';

    var arrNum = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    var arrStr = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"];

    var input = argument[0];

    if (arrNum.indexOf(input) != -1) {
        console.log(arrStr[Number(input)]);
    } else {
        console.log("not a digit");
    }
}