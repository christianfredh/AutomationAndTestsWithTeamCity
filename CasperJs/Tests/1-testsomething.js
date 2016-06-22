casper.test.begin("Verify that kittens are cute", function (test) {

    var optionUrl = casper.cli.get("url");

    if (!optionUrl) {
        test.fail("URL option is not configured.");
    }

    casper.start(optionUrl);

    casper.then(function () {
        test.assertExist("img");
    });

    casper.run(function () {
        test.done();
        casper.captureTest(test);
    });
});
