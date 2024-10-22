

using UnrealBuildTool;
using System.Collections.Generic;

public class UeGameEditorTarget : TargetRules
{
	public UeGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "UeGame" } );
	}
}