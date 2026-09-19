using System.Collections.Generic;
using FlaxAdaptiveInput.Modifiers;
using FlaxAdaptiveInput.Triggers;
using FlaxEngine;

namespace FlaxAdaptiveInput;

// Ensure your InputMappingEntry structure handles Triggers:
public struct InputMappingEntry()
{
    public bool UseAxis = false;

    [VisibleIf(nameof(UseAxis))] public InputAxisType AxisType = InputAxisType.KeyboardOnly;
    
    [Space(3)]
    [Header("Bounds")]
    [VisibleIf(nameof(UseAxis), true)]
    public KeyboardKeys Key = KeyboardKeys.None;
    
    [VisibleIf(nameof(UseAxis), true)]
    public GamepadButton GamepadButton = GamepadButton.None;

    [Space(3)]
    [VisibleIf(nameof(UseAxis))]
    public KeyboardKeys KeyPositive = KeyboardKeys.None;
    [VisibleIf(nameof(UseAxis))]
    public KeyboardKeys KeyNegative = KeyboardKeys.None;
    [VisibleIf(nameof(UseAxis))]
    public GamepadButton GamepadPositiveButton = GamepadButton.None;
    [VisibleIf(nameof(UseAxis))]
    public GamepadButton GamepadNegativeButton = GamepadButton.None;

    // Flax's native JSON asset editor natively draws and manages polymorphic classes inline!
    [Collection(Display = CollectionAttribute.DisplayType.Header)]
    public List<InputModifier> Modifiers = [];
    
    [Tooltip("Triggers that determine the exact state rules for this binding edited cleanly inline.")]
    [Collection(Display = CollectionAttribute.DisplayType.Header)]
    public List<IInputTrigger> Triggers = [];
}

public struct InputActionEntry()
{
    [Tooltip("The abstract Input Action asset this mapping fulfills.")]
    public JsonAssetReference<InputAction> InputAction;
    
    [Collection(Display = CollectionAttribute.DisplayType.Header)]
    public List<InputMappingEntry> InputMapping = [];
}

[ContentContextMenu("New/Adaptive Input/Input Mapping")]
public class InputMappingContext
{
    public string ContextName;
    
    [Collection(Display = CollectionAttribute.DisplayType.Header)]
    public List<InputActionEntry> Mappings = [];
}