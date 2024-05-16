using Godot;
using System;

public partial class Player : RigidBody2D
{

	[Export] private float _power = 100f;
	
	private Viewport _viewport;
	private Vector2 _mousePosition;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_viewport = GetViewport();
	}

	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Get the mouse position
		_mousePosition = _viewport.GetMousePosition();

		if (Input.IsActionPressed("Fire"))
		{
			GD.Print("Fire! " + _mousePosition);
			ApplyCentralImpulse(Vector2.Up * _power);
		}
	}
	
}
