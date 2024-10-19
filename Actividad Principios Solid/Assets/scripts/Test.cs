using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public NPC npc;
    public Vector3 destino;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            npc.EjecutarMovimiento(destino);
        }
    }
}
