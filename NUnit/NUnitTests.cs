namespace NUnit
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using FakeItEasy;
    using NUnit.Framework;
    using FluentAssertions;
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void PantsServiceTests()
        {
            var pantsRepository = A.Fake<IPantsRepository>();

            A.CallTo(() => pantsRepository.GetAllPants()).Returns(new List<Pants>
            {
                new Pants { Color = "blue" },
                new Pants { Color = "red" },
                new Pants { Color = "blue" },
                new Pants { Color = "blue" },
                new Pants { Color = "purple" },
                new Pants { Color = "yellow" },
                new Pants { Color = "green" },
            });
            
            var pantsService = new PantsService(pantsRepository);

            var pants = pantsService.GetPantsOfColor("blue");

            pants.Should().HaveCount(3);
        }
    }

    public class PantsService
    {
        private readonly IPantsRepository pantsRepository;

        public PantsService(IPantsRepository pantsRepository)
        {
            this.pantsRepository = pantsRepository;
        }

        public IEnumerable<Pants> GetPantsOfColor(string color)
        {
            return pantsRepository
                .GetAllPants()
                .Where(pants => pants.Color == color);
        }
    }

    public interface IPantsRepository
    {
        IEnumerable<Pants> GetAllPants();
    }

    public class Pants
    {
        public string Color { get; set; }
    }
}
