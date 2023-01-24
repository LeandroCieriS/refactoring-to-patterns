namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private string _internetLabel;
        private int? _telephoneNumber;
        private string[] _tvChannels;
        private int? _mobile;

        public bool HasInternet()
        {
            return _internetLabel != null;
        }


        public bool HasVOIP()
        {
            return _telephoneNumber != null;
        }

        public bool HasTv()
        {
            return _tvChannels != null;
        }

        public static ProductPackage WithInternet(string internetLabel)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel
            };
            return productPackage;
        }

        public static ProductPackage WithInternetAndVoip(string internetLabel, int telephoneNumber)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel,
                _telephoneNumber = telephoneNumber
            };
            return productPackage;
        }

        public static ProductPackage WithInternetAndTv(string internetLabel, string[] tvChannels)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel,
                _tvChannels = tvChannels
            };
            return productPackage;
        }

        public static ProductPackage WithInternetVoipAndTv(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel,
                _telephoneNumber = telephoneNumber,
                _tvChannels = tvChannels
            };
            return productPackage;
        }

        public bool HasMobile()
        {
            return _mobile != null;
        }

        public static ProductPackage WithInternetAndMobile(string internetLabel, int mobileNumber)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel,
                _mobile = mobileNumber
            };
            return productPackage;
        }

        public static ProductPackage WithInternetMobileAndTv(string internetLabel, int mobileNumber, string[] tvChannels)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel,
                _mobile = mobileNumber,
                _tvChannels = tvChannels
            };
            return productPackage;
        }

        public static ProductPackage WithInternetMobileVOIPAndTv(string internetLabel, int mobileNumber, int telephoneNumber, string[] tvChannels)
        {
            var productPackage = new ProductPackage
            {
                _internetLabel = internetLabel,
                _mobile = mobileNumber,
                _tvChannels = tvChannels,
                _telephoneNumber = telephoneNumber
            };
            return productPackage;
        }
    }
}