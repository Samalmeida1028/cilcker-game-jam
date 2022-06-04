using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatHandler : MonoBehaviour
{
    GameObject player;
    int totalFishVal = 0;
    int totalClicks;
    int totalFishHooked;
    int totalFishCaught;
    public TextMeshProUGUI fishText;
    

    void Awake(){
        player = GameObject.FindWithTag("Player");
        fishText = GameObject.FindWithTag("FishUI").GetComponent<TMPro.TextMeshProUGUI>();
        UpdateStatsFromPlayer();
    }

    public void UpdateStatsFromPlayer(){
    //     stats = player.GetComponent<PlayerStatsController>();
    //     totalFishCaught = stats.totalFishCaught;
    //     totalFishHooked = stats.totalFishHooked;
    //     totalClicks = stats.totalClicks;
    //     totalFishCaught = stats.currentFishCaught;
    }

    // void UpdatePlayerStats(){
    //     stats = player.GetComponent<PlayerStatsController>();
    //     stats.totalFishCaught = totalFishCaught;
    //     stats.totalFishHooked = totalFishHooked;
    //     stats.totalClicks = totalClicks;
    //     stats.currentFishCaught = totalFishCaught;
    // }

    public void setTotalVal(int val){
        totalFishVal += val;
        fishText.text = totalFishVal.ToString();
    }

}
