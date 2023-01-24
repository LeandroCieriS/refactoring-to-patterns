namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string _internetLabel;
        private readonly int? _telephoneNumber;
        private readonly string[] _tvChannels;
        private readonly int? _mobile;

        private ProductPackage(string internetLabel, int? telephoneNumber, string[] tvChannels, int? mobile)
        {
            _internetLabel = internetLabel;
            _telephoneNumber = telephoneNumber;
            _tvChannels = tvChannels;
            _mobile = mobile;
        }

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

        public bool HasMobile()
        {
            return _mobile != null;
        }

        public static ProductPackage WithInternet(string internetLabel)
        {
            return new ProductPackage(internetLabel, null, null, null);
        }

        public static ProductPackage WithInternetAndVoip(string internetLabel, int telephoneNumber)
        {
            return new ProductPackage(internetLabel, telephoneNumber, null, null);
        }

        public static ProductPackage WithInternetAndTv(string internetLabel, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, null, tvChannels, null);
        }

        public static ProductPackage WithInternetVoipAndTv(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels, null);
        }

        public static ProductPackage WithInternetAndMobile(string internetLabel, int mobileNumber)
        {
            return new ProductPackage(internetLabel, null, null, mobileNumber);
        }

        public static ProductPackage WithInternetMobileAndTv(string internetLabel, int mobileNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, null, tvChannels, mobileNumber);
        }

        public static ProductPackage WithInternetMobileVOIPAndTv(string internetLabel, int mobileNumber, int telephoneNumber, string[] tvChannels)
        {
            return new ProductPackage(internetLabel, telephoneNumber, tvChannels, mobileNumber);
        }
    }
}