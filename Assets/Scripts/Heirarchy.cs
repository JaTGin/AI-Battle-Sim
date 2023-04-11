using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heirarchy : MonoBehaviour
{
    public ICollection<Soldier> soldier { get; set; }
    public ICollection<MovementHandler> movementhandler { get; set; }
    public ICollection<ActionHandler> actionhandler { get; set; }
    public ICollection<FieldOfView> fieldofview { get; set; }
    public ICollection<SignalHandler> signalhandler { get; set; }
    public ICollection<MoraleHandler> moralehandler { get; set; }
}
