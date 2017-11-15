using System.IO;

namespace MSTest.Library.Services
{
    public static class ValueService
    {
        public static string GetRandomString() => Path.GetRandomFileName().Remove(8);
    }
}
