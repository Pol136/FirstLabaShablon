using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
{
    public void Move();
    public void CanMove();
    public void CantMove();
}
