namespace Calculate
{
    /// <summary>
    /// Utility class for processing the given input
    /// </summary>
    public static class CalculateUtility
    {
        /// <summary>
        /// Method to process the input and generate the appropiate string.
        /// </summary>
        /// <param name="input">Parameter to process the value</param>
        /// <returns>Equivalent string value for the given input</returns>
        public static string Calculate(double input)
        {
            switch (input)
            {
                case 0:
                    return "0";

                case 1:
                    return "1";

                case 2:
                    return "01";

                default:
                    return Calculate(input - 1) + Calculate(input - 2);
            }
        }
    }
}