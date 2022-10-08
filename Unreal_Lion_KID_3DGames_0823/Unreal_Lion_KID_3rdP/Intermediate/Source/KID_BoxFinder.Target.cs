using UnrealBuildTool;

public class KID_BoxFinderTarget : TargetRules
{
	public KID_BoxFinderTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("KID_BoxFinder");
	}
}
