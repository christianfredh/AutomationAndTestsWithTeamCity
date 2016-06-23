casper.test.begin("Verify that kittens are cute", function (test) {

    var optionUrl = casper.cli.get("url");

    if (!optionUrl) {
        test.fail("URL option is not configured.");
    }


    casper.start(optionUrl, function () {

        // Initial frame
        var frame = 0;
        // Add an interval every second
        setInterval(function () {

            var frameString = frame.toString();

            if (frame < 10) {
                frameString = "00" + frame;
            } else if (frame < 100) {
                frameString = "0" + frame;
            }


            // Render an image with the frame name
            casper.capture("frames/dragon" + frameString + ".png", {
                top: 0,
                left: 0,
                width: 640,
                height: 400
            });
            casper.capture("ffmpeg/dragon" + frameString + ".png", {
                top: 0,
                left: 0,
                width: 640,
                height: 400
            });
            frame++;
        }, 15);
    });

    //casper.thenOpen(optionUrl);

    casper.thenClick(".links a:first-child");

    casper.then(function () {
        test.assertExist("img");
    });

    casper.run(function () {
        test.done();
        casper.captureTest(test);
    });
});
