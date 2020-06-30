using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AirMeter : MonoBehaviour
{
    public float air = 10f;
    public float maxAir = 10f;
    public float airBurnRate = .1f;

    private Player player;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;

        if(air > 0)
        {
            air -= Time.deltaTime * airBurnRate;
            slider.value = air / maxAir;
        }
        else
        {
            var script = player.GetComponent<Explode>();
            script.OnExplode();
        }
    }
}
