using Godot;
using System;

public partial class AirstreamToggle : Area2D
{
	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "Player")
		{
			UpwardsStream.Instance.isStreamActive = true;
			GD.Print("Airstream is active");
		}
	}
}
