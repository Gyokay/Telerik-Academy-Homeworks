(function () {
    var sumArrNumbers;

    sumArrNumbers = function (arr) {
        var i,
            len,
            currentNum,
            sum = 0;
            

        if (arr === undefined) {
            throw new Error();
        }

        len = arr.length;

        if (len === 0) {
            return null;
        }

        for (i = 0; i < len; i += 1) {
            currentNum = +arr[i];

            if (isNaN(currentNum)) {
                throw new Error();
            }

            sum += currentNum;
        }

        return sum;
    };


    //tests
    // var result = sumArrNumbers([4, 5, 5]);
    // console.log(result === 14);

    // result = sumArrNumbers([]);
    // console.log(result === null);

    // result = sumArrNumbers(["asdf", 5, 3]);

} ());