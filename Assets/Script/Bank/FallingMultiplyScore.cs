using UnityEngine;

public class FallingMultiplyScore : MonoBehaviour
{
  public static int MultiplyScore(int score, int multiplicity)
    {
        if (multiplicity != 0)
        return score * multiplicity;
        else return score;
    }
}
