function solve(args) {
    "use strict";

    let word = args[0];
    let str = args[1];

    let regex = new RegExp(word, "gi");
    let match = str.match(regex);

    console.log(match.length);
}