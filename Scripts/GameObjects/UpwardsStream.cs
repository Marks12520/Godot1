using Godot;
using System;

public partial class UpwardsStream : Area2D
{
	public static UpwardsStream Instance;
	
	public bool isStreamActive = true;
	public bool isPlayerInStream;

	public override void _Ready()
	{
		Instance = this;
	}
	
	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "Player")
		{
			isPlayerInStream = true;
		}
	}

	private void _on_body_exited(Node2D body)
	{
		if (body.Name == "Player")
		{
			isPlayerInStream = false;
		}
	}
}
