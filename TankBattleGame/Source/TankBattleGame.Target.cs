// Copyright 2017

using UnrealBuildTool;
using System.Collections.Generic;

public class TankBattleGameTarget : TargetRules
{
	public TankBattleGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TankBattleGame" } );
	}
}
