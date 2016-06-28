function solve(args) {

    var arr = args[1].split(' ').map(Number);

    function returnMax(arr, startIndex) {
        var newArr = [];

        for (var i = startIndex; i < arr.length; i += 1) {
            newArr[i] = arr[i];
        }

        return Math.max.apply(null, newArr);
    }

    function sortAscending(arr) {

        function sortNumber(a,b) {
            return a - b;
        }

        return arr.sort(sortNumber);
    }

    function sortDescending(arr) {
        function sortNumber(a,b) {
            return a - b;
        }

        return arr.sort(sortNumber).reverse();
    }

    return console.log(sortAscending(arr).join(' '));
}