using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right_btn : MonoBehaviour
{
    public GPSManager player;
    public void RotatePlayer()
    {
        if(player.pos_dir == 0)
            player.pos_dir = 1;
        else if(player.pos_dir == 1)
            player.pos_dir = 2;
        else if(player.pos_dir == 2)
            player.pos_dir = 3;
        else if(player.pos_dir == 3)
            player.pos_dir = 0;
    }
}
