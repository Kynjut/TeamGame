using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI HealthStat;
    public HealthComponent Health;

    public void Update()
    {
        HealthStat.text = $"Health {Health.Health}";
    }
}
