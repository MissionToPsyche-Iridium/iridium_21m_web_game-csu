using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class Waves : MonoBehaviour
{
    public int radiation = 0;
    public int count = 0;
    public GameObject t1, t2, t3, t4, t5;
    public GameObject b1, b2, b3, b4, b5;
    public GameObject l1, l2, l3, l4, l5;
    public GameObject r1, r2, r3, r4, r5;
    public void UpdateRad()
    {

        switch (radiation)
        {
            case 0:
                t1.SetActive(false);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(false);
                b2.SetActive(false);
                b3.SetActive(false);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(false);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(false);
                r2.SetActive(false);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 1:
                t1.SetActive(true);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(false);
                b3.SetActive(false);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(false);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(false);
                r2.SetActive(false);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 2:
                t1.SetActive(true);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(false);
                b3.SetActive(false);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(false);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 3:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(false);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(false);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 4:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(false);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(true);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(true);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 5:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(true);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(true);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(true);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(true);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 6:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(true);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(true);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(true);
                l3.SetActive(true);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(true);
                r3.SetActive(true);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 7:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(true);
                t4.SetActive(true);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(true);
                b4.SetActive(true);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(true);
                l3.SetActive(true);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(true);
                r3.SetActive(true);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            case 8:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(true);
                t4.SetActive(true);
                t5.SetActive(false);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(true);
                b4.SetActive(true);
                b5.SetActive(false);
                l1.SetActive(true);
                l2.SetActive(true);
                l3.SetActive(true);
                l4.SetActive(true);
                l5.SetActive(false);
                r1.SetActive(true);
                r2.SetActive(true);
                r3.SetActive(true);
                r4.SetActive(true);
                r5.SetActive(false);
                break;
            case 9:
                t1.SetActive(true);
                t2.SetActive(true);
                t3.SetActive(true);
                t4.SetActive(true);
                t5.SetActive(true);
                b1.SetActive(true);
                b2.SetActive(true);
                b3.SetActive(true);
                b4.SetActive(true);
                b5.SetActive(true);
                l1.SetActive(true);
                l2.SetActive(true);
                l3.SetActive(true);
                l4.SetActive(true);
                l5.SetActive(true);
                r1.SetActive(true);
                r2.SetActive(true);
                r3.SetActive(true);
                r4.SetActive(true);
                r5.SetActive(true);
                break;
            case 10:
                t1.SetActive(false);
                t2.SetActive(false);
                t3.SetActive(false);
                t4.SetActive(false);
                t5.SetActive(false);
                b1.SetActive(false);
                b2.SetActive(false);
                b3.SetActive(false);
                b4.SetActive(false);
                b5.SetActive(false);
                l1.SetActive(false);
                l2.SetActive(false);
                l3.SetActive(false);
                l4.SetActive(false);
                l5.SetActive(false);
                r1.SetActive(false);
                r2.SetActive(false);
                r3.SetActive(false);
                r4.SetActive(false);
                r5.SetActive(false);
                break;
            default:
                break;
        }
    }

    public void RaiseRad()
    {
        radiation += 1;
        count += 1;

        UpdateRad();
    }

    public void LowerRad()
    {
        radiation -= 1;
        count += 1;

        UpdateRad();
    }
}
