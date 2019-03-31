const five = require('johnny-five');
const board = new five.Board();

board.on('ready', function() {
	const led = new five.Led(5);
	
	this.repl.inject({
		// Allow limited on/off control access to the
		// Led instance from the REPL.
		on: function () {
			led.on();
		},
		off: function () {
			led.stop().off();
		},
		blink: function(interval) {
			led.blink(interval || 500);
		},
		pulse: function(interval) {
			led.pulse(interval || 500);
		},
		fancyPulse: function(duration) {
			led.pulse({
				easing: "linear",
				duration,
				cuePoints: [0, 0.2, 0.4, 0.6, 0.8, 1],
				keyFrames: [0, 10, 0, 50, 0, 255],
				onstop: function () {
					console.log("Animation stopped");
				}
			});
		}
	});
});