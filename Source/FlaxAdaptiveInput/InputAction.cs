using System;
using FlaxEngine;

namespace FlaxAdaptiveInput;

public enum InputActionType
{
    Digital, // On/Off (Button press)
    Axis1D,  // Float (Trigger/Throttle)
    Axis2D,   // Vector2 (Thumbstick/Mouse movement)
    Axis3D,   // Vector2 (Thumbstick/Mouse movement)
}

[ContentContextMenu("New/Input System/Input Action")]

public class InputAction
{
    // ReSharper disable once InconsistentNaming
    [HideInEditor]
    public Guid ID = Guid.NewGuid();
    
    [Tooltip("Visual identifier only used for debugging purposes.")]
    public string Name = "DefaultInputAction";
    
    [Tooltip("The type of input expected by this InputAction.")]
    public InputActionType ActionType = InputActionType.Digital;
}