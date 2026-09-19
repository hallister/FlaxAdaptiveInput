using FlaxEngine;

namespace FlaxAdaptiveInput.Triggers;

public class TriggerConfig
{
    [Tooltip("Select the explicit trigger behavior style.")]
    [TypeReference(typeof(InputTrigger))]
    public SoftTypeReference TriggerType;

    public InputTrigger Trigger;
}
