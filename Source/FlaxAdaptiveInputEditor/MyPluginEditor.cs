using System;
using FlaxAdaptiveInput;
using FlaxEditor;
using FlaxEditor.GUI;

namespace FlaxAdaptiveInputEditor;

/// <summary>
/// The sample editor plugin using <see cref="MyPlugin"/>.
/// </summary>
/// <seealso cref="FlaxEditor.EditorPlugin" />
public class MyPluginEditor : EditorPlugin
{
    private ToolStripButton _button;

    /// <inheritdoc />
    public override Type GamePluginType => typeof(MyPlugin);

    /// <inheritdoc />
    public override void InitializeEditor()
    {
        base.InitializeEditor();
    }

    /// <inheritdoc />
    public override void Deinitialize()
    {
        if (_button != null)
        {
            _button.Dispose();
            _button = null;
        }

        base.Deinitialize();
    }
}