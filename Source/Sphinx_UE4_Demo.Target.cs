// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Sphinx_UE4_DemoTarget : TargetRules
{
	public Sphinx_UE4_DemoTarget(TargetInfo Target) : base(Target)
    {
		Type = TargetType.Game;
        ExtraModuleNames.AddRange(new string[] { "Sphinx_UE4_Demo" });
    }
}
