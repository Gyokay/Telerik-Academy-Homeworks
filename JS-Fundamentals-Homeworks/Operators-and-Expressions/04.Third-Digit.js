function solve(argument) {
	var n = argument[0];

	var digitStr = n[n.length - 3];

	if (digitStr === "7") {
		return "true";
	} else {
		if (digitStr === undefined) { return "false 0"; }
		else { return "false " + digitStr; }
	}
}