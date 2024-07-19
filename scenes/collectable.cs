using Godot;
using System;

public partial class collectable : Area2D
{
	private GameManager gameManager;

    public override void _Ready()
    {
        base._Ready();
		gameManager = GetTree().Root.GetNode<GameManager>("GameManager");
        //GD.Print(gameManager);
    }

    public void _on_body_entered(Node2D body)
	{
		if(body.Name == "CharacterBody2D"){
			QueueFree();
			gameManager.addPoint();
		}
	}
}



