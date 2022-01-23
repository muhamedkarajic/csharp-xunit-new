namespace GreatMathLibrary;

public class BasicMath
{
    public static int Add(int a, int b)
    {
        if (a < 0)
            throw new Exception($"Value 'a' must be greather or equal to 0.");
        else if (a < 0)
            throw new Exception($"Value 'b' must be greather or equal to 0.");

        return a + b;
    }
}
