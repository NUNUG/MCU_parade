const five = require('johnny-five');
const board = new five.Board();

board.on('ready', function() {
	const led = new five.Led(5);
	led.blink(500);
});