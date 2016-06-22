casper.test.begin("TestSomething", function (test) {

    var optionUrl = casper.cli.get("url");

    if (!optionUrl) {
        test.fail("URL option is not configured.");
    }

    casper.start(optionUrl);

    casper.then(function () {
        casper.waitForSelector("#lst-ib", function () {
            casper.captureTest(test);

            casper.sendKeys("#lst-ib", "CasperJS");
            casper.clickLabel("Sök på Google");
            test.assertSelectorExist("[href='http://casperjs.org/']");
        });
    });

    casper.run(function () {
        test.done();
        casper.captureTest(test);
    });
});
