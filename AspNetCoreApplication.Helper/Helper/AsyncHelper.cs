using System;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Helper.Helper
{
    public static class AsyncHelper
    {
        public static Task<T> AsyncFunction<T>(Func<T> function)
        {
            Task<T> task = Task<T>.Factory.StartNew(function);
            return task;
        }
    }
}
