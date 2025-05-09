namespace Preprocessor_Directives_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("حالت دیباگ فعال است.");
#else
            Console.WriteLine("حالت اجرا (Release) فعال است.");
#endif

#warning این یک هشدار است!
//#error این یک خطای کامپایل است!

            #region تعریف متغیرها
            int number = 10;
            string name = "Ali";
            #endregion

            #region متدها
            void ShowInfo()
            {
                Console.WriteLine($"Name: {name}, Number: {number}");
            }
            #endregion

#pragma warning disable CS0168

            void TestMethod()
            {
                int unusedVariable; // هشدار CS0168: متغیر استفاده نشده
            }

#pragma warning restore CS0168

#if WINDOWS
            Console.WriteLine("در حال اجرا روی ویندوز");
#elif LINUX
            Console.WriteLine("در حال اجرا روی لینوکس");
#else
            Console.WriteLine("پلتفرم نامشخص");
#endif
        }
    }
}
