namespace Statistics.Helper
{
    public class ArgumentCheck : IArgumentCheck
    {
        public static IArgumentCheck Instance { get; } = new ArgumentCheck();
        private ArgumentCheck() { }
    }

}