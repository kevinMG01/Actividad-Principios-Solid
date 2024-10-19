using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovimiento : MonoBehaviour, IMovimiento
{
    public void Mover(Vector3 objetivo)
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo, Time.deltaTime * 3);
    }

}
