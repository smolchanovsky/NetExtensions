namespace NetExtensions.Conversions
{
    public static class DataSizeConversionExtensions
    {
	    public static ushort Bytes(this ushort value) =>
		    value;

        public static ushort Bytes(this int value) =>
	        (ushort) value;

        public static ushort Bytes(this long value) =>
	        (ushort) value;

        public static ushort Kilobytes(this ushort value) =>
	        (ushort) (value * DataSizeConstants.Kilobyte);

        public static ushort Kilobytes(this int value) =>
	        (ushort) (value * DataSizeConstants.Kilobyte);

        public static ushort Kilobytes(this long value) =>
	        (ushort) (value * DataSizeConstants.Kilobyte);

        public static ushort Kilobytes(this double value) =>
	        (ushort) (value * DataSizeConstants.Kilobyte);

        public static ushort Megabytes(this ushort value) =>
	        (ushort) (value * DataSizeConstants.Megabyte);

        public static ushort Megabytes(this int value) =>
	        (ushort) (value * DataSizeConstants.Megabyte);

        public static ushort Megabytes(this long value) =>
	        (ushort) (value * DataSizeConstants.Megabyte);

        public static ushort Megabytes(this double value) =>
	        (ushort) (value * DataSizeConstants.Megabyte);

        public static ushort Gigabytes(this ushort value) =>
	        (ushort) (value * DataSizeConstants.Gigabyte);

        public static ushort Gigabytes(this int value) =>
	        (ushort) (value * DataSizeConstants.Gigabyte);

        public static ushort Gigabytes(this long value) =>
	        (ushort) (value * DataSizeConstants.Gigabyte);

        public static ushort Gigabytes(this double value) =>
	        (ushort) (value * DataSizeConstants.Gigabyte);

        public static ushort Terabytes(this ushort value) =>
	        (ushort) (value * DataSizeConstants.Terabyte);

        public static ushort Terabytes(this int value) =>
	        (ushort) (value * DataSizeConstants.Terabyte);

        public static ushort Terabytes(this long value) =>
	        (ushort) (value * DataSizeConstants.Terabyte);

        public static ushort Terabytes(this double value) =>
	        (ushort) (value * DataSizeConstants.Terabyte);

        public static ushort Petabytes(this ushort value) =>
	        (ushort) (value * DataSizeConstants.Petabyte);

        public static ushort Petabytes(this int value) =>
	        (ushort) (value * DataSizeConstants.Petabyte);

        public static ushort Petabytes(this long value) =>
	        (ushort) (value * DataSizeConstants.Petabyte);

        public static ushort Petabytes(this double value) =>
	        (ushort) (value * DataSizeConstants.Petabyte);
    }
}
