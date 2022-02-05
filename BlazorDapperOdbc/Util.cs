namespace BlazorDapperOdbc
{
    public static class Util
    {
        public static string GeraGuid()
        {
            return Guid.NewGuid().ToString().Replace("-", "")[..12].ToUpper();
        }
    }
}
