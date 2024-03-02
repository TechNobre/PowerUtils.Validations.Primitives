using System;

namespace PowerUtils.Validations
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public static class ErrorCodes
    {
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        private const string PATTERN_ERROR_CODE_WITH_LIMIT = "{0}:{1}"; // {0} => ERROR CODE, {1} => LIMIT

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string REQUIRED = "REQUIRED";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string INVALID = "INVALID";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string UNAUTHORIZED = "UNAUTHORIZED";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string FORBIDDEN = "FORBIDDEN";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MIN = "MIN";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MAX = "MAX";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MIN_ZERO = "MIN:0";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MAX_ZERO = "MAX:0";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MIN_DATETIME_UTCNOW = "MIN:DATETIME_UTCNOW";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MAX_DATETIME_UTCNOW = "MAX:DATETIME_UTCNOW";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MIN_LATITUDE = "MIN:-90";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MAX_LATITUDE = "MAX:90";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MIN_LONGITUDE = "MIN:-180";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string MAX_LONGITUDE = "MAX:180";


        [Obsolete("This constant is deprecated. It will be removed on 2022/09/30. Use the new constant 'DUPLICATED'")]
        public const string ALREADY_EXISTS = "ALREADY_EXISTS";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string DUPLICATED = "DUPLICATED";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string NOT_FOUND = "NOT_FOUND";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public const string EXPIRED = "EXPIRED";

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(string min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(int min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(uint min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(long min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(ulong min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(float min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(double min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(decimal min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted(DateTime min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString("yyyy-MM-dd"));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMinFormatted<TValue>(TValue min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(string max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(int max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(uint max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(long max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(ulong max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(float max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(double max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(decimal max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted(DateTime max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString("yyyy-MM-dd"));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetMaxFormatted<TValue>(TValue max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));
    }
}
