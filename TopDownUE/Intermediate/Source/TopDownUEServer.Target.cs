using UnrealBuildTool;

public class TopDownUEServerTarget : TargetRules
{
	public TopDownUEServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TopDownUE");
	}
}
