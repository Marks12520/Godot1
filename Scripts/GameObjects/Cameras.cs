using Godot;
using System;
using PhantomCamera;

public partial class Cameras : Node
{
	private Node2D followCamera;
	private Node2D idleCamera;
	[Export] private Node2D followTarget;
	[Export] private CollisionShape2D[] limitShape;
	
	public override void _Ready()
	{
		followCamera = GetNode<Node2D>("FollowCamera");
		idleCamera = GetNode<Node2D>("IdleCamera");

		followCamera.AsPhantomCamera2D().FollowTarget = followTarget;
		idleCamera.AsPhantomCamera2D().FollowTarget = followTarget;

		followCamera.AsPhantomCamera2D().LimitTarget = limitShape[0].GetPath();
		idleCamera.AsPhantomCamera2D().LimitTarget = limitShape[0].GetPath();
	}

	public void SetIdleCameraPriority(int priority)
	{
		idleCamera.AsPhantomCamera2D().Priority = priority;
	}

	public void ChangeBounds(int i)
	{
		followCamera.AsPhantomCamera2D().LimitTarget = limitShape[i].GetPath();
		idleCamera.AsPhantomCamera2D().LimitTarget = limitShape[i].GetPath();
	}
}
