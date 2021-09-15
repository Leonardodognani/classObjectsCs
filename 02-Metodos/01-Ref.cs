namespace Classes.Metodos
{
    public class Ref
    {
        static void Inverter(Ref int x, Ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(Ref i, Ref j)
        }   System.Console.WriteLine($"{i} {J}");   //ecreve 2 1
    }
}