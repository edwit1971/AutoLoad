using Godot;
using System;

public partial class DataManager : Node
{
	public float Health;
	public float Score;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Health = 100.0f;
		Score = 0.0f;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
