function solve(argument) {
	var n = parseInt(argument[0]);

	if (n % 7 === 0 && n % 5 === 0) {
		console.log("true " + n);
	} else {
		console.log("false " + n);
	}
}