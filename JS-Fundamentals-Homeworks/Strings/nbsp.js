function solve(args) {
    "use strict";

    let txt = args[0];
    let newStr = txt.replace(/\s/g, '&nbsp;');

    console.log(newStr);
}