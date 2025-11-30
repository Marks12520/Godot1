using Godot;
using System;

public partial class ChangeBound : Area2D
{
	[Export] private Cameras cameras;
	[Export] private int i;
	
	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "Player")
		{
			cameras.ChangeBounds(i);
		}
	}
}
