using UnityEngine;
using UnityEngine.Rendering;

public class Glitch_Effect : MonoBehaviour
{
    public Volume glitchvolume;
    public Count_down_Timer countdowntimer;

    void Start()
    {
        if (countdowntimer == null)
            countdowntimer = FindAnyObjectByType<Count_down_Timer>();

        if (glitchvolume != null)
        {
            glitchvolume.weight = 0f;
           
        }
       
    }

    void Update()
    {
        if (countdowntimer == null || glitchvolume == null) return;

        float timeleft = countdowntimer.gameplay_timer;

        if (timeleft <= 60f)
        {
            float progress = Mathf.Clamp01((60f - timeleft) / 60f);
            glitchvolume.weight = Mathf.SmoothStep(0f, 1f, progress);
        }
        else
        {
         
            glitchvolume.weight = 0f;
        }
    }
}