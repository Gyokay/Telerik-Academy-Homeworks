function solve(argument) {
    var n = Number(argument[0]);

    var mask = 1 << 3;

    if ((n & mask) != 0) {
        return 1; // bit is set
    } else {
        return 0; // bit is not set
    }
}