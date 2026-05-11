namespace Cracking.TwoPointers.PointersForEach;

public class CommonElementsSolution
{
    public static int[] FindCommonElements(int[] a, int[] b)
    {
        List<int> c = [];

        var ap = 0;
        var bp = 0;

        while (a.Length > ap && b.Length > bp)
        {
            if (a[ap] == b[bp])
            {
                c.Add(a[ap]);
                ++ap;
                ++bp;
            }
            else if (a[ap] < b[bp])
            {
                ++ap;
            }
            else
            {
                ++bp;
            }
        }

        return c.ToArray();
    }
}