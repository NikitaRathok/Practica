namespace num3
{
    internal partial class Program
    {
        class InfoObj
        {
            public static void Info<tip>(tip obj) where tip: Travel
            {
                obj.PrintTravel();
            }
        }
    }
}
