function solve(argument) {
    var x = Number(argument[0]);
    var y = Number(argument[1]);
    var rad = 2;

    var centerX = 0;
    var centerY = 0;

    var isInCircle = Math.pow(x - centerX, 2) 
                   + Math.pow(y - centerY, 2) 
                   < Math.pow(rad, 2);

    var distance = Math.sqrt(Math.pow(x - centerX, 2) + Math.pow(y - centerY, 2));

    if (isInCircle) {
        return "yes " + distance.toFixed(2);
    } else {
        return"no " + distance.toFixed(2);
    }
}