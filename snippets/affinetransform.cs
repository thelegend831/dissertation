[Serializable]
public class AffineTransform
{
    public float[,] R = new float[3, 3];
    public float[] t = new float[3];

    public AffineTransform()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                    R[i, j] = 1;
                else
                    R[i, j] = 0;
            }
            t[i] = 0;
        }
    }
}