using Robust.Shared.GameStates;

namespace Content.Shared.Slippery;

/// <summary>
/// Status effect that prevents the affected entity from slipping while active.
/// Placed on a status effect entity and relayed to its target via <see cref="SlipperySystem"/>.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class NoSlipStatusEffectComponent : Component
{

}
