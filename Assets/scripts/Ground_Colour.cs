using UnityEngine;

public class Ground_Colour : MonoBehaviour
{
    public Material groundmaterial;
    public Count_down_Timer countdowntimer;

    void Start()
    {
        if (countdowntimer == null)
            countdowntimer = FindObjectOfType<Count_down_Timer>();
    }

    void Update()
    {
        if (countdowntimer == null) return;

        float timeleft = countdowntimer.gameplay_timer;

        // ✅ breathing gets faster every 40 seconds
        if (timeleft > 120f)
        {
            groundmaterial.SetFloat("_BreathSpeed", 1f); // ✅ slow
        }
        else if (timeleft > 80f)
        {
            groundmaterial.SetFloat("_BreathSpeed", 2f); // ✅ medium
        }
        else if (timeleft > 40f)
        {
            groundmaterial.SetFloat("_BreathSpeed", 4f); // ✅ fast
        }
        else
        {
            groundmaterial.SetFloat("_BreathSpeed", 8f); // ✅ very fast
        }
    }
}