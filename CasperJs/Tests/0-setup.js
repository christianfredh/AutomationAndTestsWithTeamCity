casper.test.begin("Setup", function (test) {
    
    casper.captureTest = function (testToCapture) {
        var currentTestFilePath = testToCapture.currentTestFile;

        var captureFileName = currentTestFilePath
            .substring(currentTestFilePath.lastIndexOf("/") + 1)
            .replace(".js", ".png");;

        casper.capture("Captures/" + captureFileName);
    }

    test.done();
});