using System;
using FlaxEngine;

namespace FlaxAdaptiveInput;

/// <summary>
/// The sample game plugin.
/// </summary>
/// <seealso cref="FlaxEngine.GamePlugin" />
public class MyPlugin : GamePlugin
{
    /// <inheritdoc />
    public MyPlugin()
    {
        _description = new PluginDescription
        {
            Name = "My Plugin",
            Category = "Other",
            Author = "Flax Engine",
            AuthorUrl = null,
            HomepageUrl = null,
            RepositoryUrl = "https://github.com/FlaxEngine/FlaxAdaptiveInput",
            Description = "This is an example plugin project.",
            Version = new Version(1, 0),
            IsAlpha = false,
            IsBeta = false,
        };
    }
}