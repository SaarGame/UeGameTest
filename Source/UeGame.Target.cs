

using UnrealBuildTool;
using System.Collections.Generic;

public class UeGameTarget : TargetRules
{
	public UeGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "UeGame" } );
	}
}
