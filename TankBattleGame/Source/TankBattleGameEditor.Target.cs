// Copyright 2017

using UnrealBuildTool;
using System.Collections.Generic;

public class TankBattleGameEditorTarget : TargetRules
{
	public TankBattleGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TankBattleGame" } );
	}
}
