const five = require('johnny-five');
const board = new five.Board();

board.on('ready', function () {
	const led = new five.Led(5);
	const servo = new five.Servo(6);
	const button = new five.Button(2);
	const motor = new five.Motor({
		pin: 3
	});
	// const motion = new five.Motion({

	// });

	button.on('down', function() {
		led.on();
	});

	button.on('hold', function() {
		led.blink(500);
		motor.start(255);
	});

	button.on('up', function() {
		led.stop().off();
		motor.stop();
	});

	this.repl.inject({
		led: {
			on: function () {
				led.on();
			},
			off: function () {
				led.stop().off();
			},
			blink: function (interval) {
				led.blink(interval || 500);
			},
			pulse: function (interval) {
				led.pulse(interval || 500);
			},
			fancyPulse: function (duration) {
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
		},
		servo: {
			min: function () {
				servo.min();
			},
			max: function () {
				servo.max();
			},
			center: function () {
				servo.center();
			},
			to: function (deg) {
				servo.to(deg);
			}
		},
		motor,
		q: function() {
			process.exit();
		}
	});
});