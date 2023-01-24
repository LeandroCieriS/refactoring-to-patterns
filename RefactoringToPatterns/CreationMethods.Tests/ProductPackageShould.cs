using Xunit;

namespace RefactoringToPatterns.CreationMethods.Tests
{
    public class ProductPackageShould
    {
        [Fact]
        public void CreateAProductPackageWithOnlyInternet()
        {
            var productPackage = ProductPackage.WithInternet("100MB");

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndVoip()
        {
            var productPackage = ProductPackage.WithInternetAndVoip("100MB", 91233788);

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndTv()
        {
            var productPackage = ProductPackage.WithInternetAndTv("100MB", new[] { "LaLiga", "Estrenos" });

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetVoipAndTv()
        {
            ProductPackage productPackage = ProductPackage.WithInternetVoipAndTv("100MB", 91233788, new[] { "LaLiga", "Estrenos" });

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndMobile()
        {
            ProductPackage productPackage = ProductPackage.WithInternetAndMobile("100MB", 665544332);

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasMobile());
            Assert.False(productPackage.HasVOIP());
            Assert.False(productPackage.HasTv());
        }


        [Fact]
        public void CreateWithInternetMobileAndTv()
        {
            ProductPackage productPackage = ProductPackage.WithInternetMobileAndTv("100MB", 665544332, new[] { "LaLiga", "Estrenos" });

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasMobile());
            Assert.False(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetMobileVOIPAndTv()
        {
            ProductPackage productPackage = ProductPackage.WithInternetMobileVOIPAndTv("100MB", 665544332, 91233788, new[] { "LaLiga", "Estrenos" });

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasMobile());
            Assert.False(productPackage.HasVOIP());
            Assert.True(productPackage.HasTv());
        }
    }
}