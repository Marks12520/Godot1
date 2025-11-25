using Godot;
using System;

public partial class SnowParticles : CpuParticles2D
{
	public override void _Ready()
	{
		Emitting = false;
	}

	private void _on_player_start_snow()
	{
		Emitting = true;
	}
}
