namespace XUnit
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;
    
    public class DefaultPantsTests
    {
        [Fact]
        public void ColorIsPurple()
        {
            var pants = new Pants();

            pants.Color.Should().Be("purple", "purple is nice");
        }

        [Fact]
        public void TwoPockets()
        {
            var pants = new Pants();

            pants.Pockets.Should().HaveCount(2);
        }

        [Fact]
        public void EmptyPockets()
        {
            var pants = new Pants();

            pants.Pockets.Should().OnlyContain(pocket => pocket.IsEmpty);
        }
    }


    public class Pants
    {
        public Pants()
        {
            Color = "purple";
            Pockets = new List<PantsPocket>
            {
                new PantsPocket(),
                new PantsPocket(),
            };
        }

        public string Color { get; set; }

        public IEnumerable<PantsPocket> Pockets { get; set; }

    }

    public class PantsPocket
    {
        public PantsPocket()
        {
            IsEmpty = true;
        }

        public bool IsEmpty { get; set; }
    }
}
