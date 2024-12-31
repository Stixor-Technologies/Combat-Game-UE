using UnrealBuildTool;

public class TopDownUEEditorTarget : TargetRules
{
	public TopDownUEEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TopDownUE");
	}
}
