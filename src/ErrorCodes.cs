using System;

namespace PowerUtils.Validations
{
    public static class ErrorCodes
    {
        private const string PATTERN_ERROR_CODE_WITH_LIMIT = "{0}:{1}"; // {0} => ERROR CODE, {1} => LIMIT

        public const string REQUIRED = "REQUIRED";

        public const string INVALID = "INVALID";

        public const string UNAUTHORIZED = "UNAUTHORIZED";
        public const string FORBIDDEN = "FORBIDDEN";


        public const string MIN = "MIN";
        public const string MAX = "MAX";


        public const string MIN_ZERO = "MIN:0";
        public const string MAX_ZERO = "MAX:0";


        public const string MIN_DATETIME_UTCNOW = "MIN:DATETIME_UTCNOW";
        public const string MAX_DATETIME_UTCNOW = "MAX:DATETIME_UTCNOW";


        public const string MIN_LATITUDE = "MIN:-90";
        public const string MAX_LATITUDE = "MAX:90";

        public const string MIN_LONGITUDE = "MIN:-180";
        public const string MAX_LONGITUDE = "MAX:180";


        [Obsolete("This constant is deprecated. It will be removed on 2022/09/30. Use the new constant 'DUPLICATED'")]
        public const string ALREADY_EXISTS = "ALREADY_EXISTS";
        public const string DUPLICATED = "DUPLICATED";

        public const string NOT_FOUND = "NOT_FOUND";

        public const string EXPIRED = "EXPIRED";

        public static string GetMinFormatted(string min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        public static string GetMinFormatted(int min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);
        public static string GetMinFormatted(uint min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        public static string GetMinFormatted(long min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        public static string GetMinFormatted(ulong min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min);

        public static string GetMinFormatted(float min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        public static string GetMinFormatted(double min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        public static string GetMinFormatted(decimal min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        public static string GetMinFormatted(DateTime min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString("yyyy-MM-dd"));

        public static string GetMinFormatted<TValue>(TValue min)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MIN, min.ToString().Replace(",", "."));

        public static string GetMaxFormatted(string max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        public static string GetMaxFormatted(int max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        public static string GetMaxFormatted(uint max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        public static string GetMaxFormatted(long max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        public static string GetMaxFormatted(ulong max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max);

        public static string GetMaxFormatted(float max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));

        public static string GetMaxFormatted(double max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));

        public static string GetMaxFormatted(decimal max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));

        public static string GetMaxFormatted(DateTime max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString("yyyy-MM-dd"));

        public static string GetMaxFormatted<TValue>(TValue max)
            => string.Format(PATTERN_ERROR_CODE_WITH_LIMIT, MAX, max.ToString().Replace(",", "."));
    }
}
