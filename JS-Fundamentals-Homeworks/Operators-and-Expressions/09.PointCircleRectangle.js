function solve(argument) {
    var x = Number(argument[0]);
    var y = Number(argument[1]);

    var circleX = 1;
    var circleY = 1;
    var circleR = 1.5;

    var rectangleX = -1;
    var rectangleX1 = -1 + 6;
    var rectangleY = 1;
    var rectangleY1 = 1 - 2;

    var isInCircle = Math.pow(x - circleX, 2) + Math.pow(y - circleY, 2) <= Math.pow(circleR, 2);

    var output = "";

    if (isInCircle) {
        output += "inside circle ";
    } else {
        output += "outside circle ";
    }

    if (((x >= rectangleX) && (x <= rectangleX1)) && ((y <= rectangleY) && (y >= rectangleY1))) {
        output += "inside rectangle";
    } else {
        output += "outside rectangle";
    }

    return output;
}