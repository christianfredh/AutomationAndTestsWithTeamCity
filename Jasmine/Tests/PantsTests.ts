/// <reference path="../ToTest/Pants.ts" />

describe("Pants", () => {

    var sut = null;

    beforeEach(() => sut = new PantsApp.Pants());

    it("is always in sunshine orange color", () => {

        let color = sut.color;

        expect(color).toBe("sunshineorange");
    });
});