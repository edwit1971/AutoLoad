using Godot;
using System;

public partial class Player : CharacterBody2D
{
	// CONSTRUCTOR
	public Player()
	{
		var dManager = GetNode<DataManager>("/root/DManager");
		dManager.Health = 100.0f;
		dManager.Score = 100.0f;
	}

}
