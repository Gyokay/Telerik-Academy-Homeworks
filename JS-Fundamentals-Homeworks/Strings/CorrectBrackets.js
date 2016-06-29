function solve(args) {
    "use strict";

    let str = args[0];

    let openBracketCount = 0;
    let closeBracketCount = 0;

    for (let i = 0; i < str.length; i += 1) {
        if (str[i] === "(") openBracketCount += 1;
        else if (str[i] === ")") closeBracketCount += 1;
    }

    if (openBracketCount === closeBracketCount) {
        console.log("Correct");
    } else {
        console.log("Incorrect");
    }
}