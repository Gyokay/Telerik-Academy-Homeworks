function solve(argument) {
	var width = Number(argument[0]);
	var height = Number(argument[1]);

	var area = width * height;
	var perimeter = (2 * height) + (2 * width);

	var output = area.toFixed(2) + " " + perimeter.toFixed(2);

	return output;

}