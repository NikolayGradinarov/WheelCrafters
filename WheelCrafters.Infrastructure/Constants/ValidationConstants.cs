namespace WheelCrafters.Infrastructure.Constants
{
    public static class ValidationConstants
    {
        public static class Category
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
        }

        public static class Product
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 5;

            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 10;

            public const int MaxQuantity = 4;
            public const int MinQuantity = 1;

            public const string PriceMaxValue = "10000.00";
            public const string PriceMinValue = "0.00";
        }
    }
}
