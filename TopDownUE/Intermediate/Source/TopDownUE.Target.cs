using UnrealBuildTool;

public class TopDownUETarget : TargetRules
{
	public TopDownUETarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TopDownUE");
	}
}
