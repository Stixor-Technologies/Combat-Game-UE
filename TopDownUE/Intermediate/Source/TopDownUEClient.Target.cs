using UnrealBuildTool;

public class TopDownUEClientTarget : TargetRules
{
	public TopDownUEClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TopDownUE");
	}
}
