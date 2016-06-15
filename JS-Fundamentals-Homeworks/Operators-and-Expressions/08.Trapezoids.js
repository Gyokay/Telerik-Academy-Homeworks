function solve(argument) {
    var a = Number(argument[0]);
    var b = Number(argument[1]);
    var h = Number(argument[2]);

    var area = ((a + b) / 2) * h;

    return area.toFixed(7);
}