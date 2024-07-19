using Godot;
using System;

public partial class GameManager : Node
{
	private int points = 0;
	// [Export]
	// public Label pointLabel { get; set; }
	private Label pointLabel;
	public override void _Ready()
	{
		base._Ready();
		pointLabel = GetTree().Root.GetNode<Label>("Node/UI/Panel/PointLabel");
		if (pointLabel == null)
		{
			GD.PrintErr("PointLabel has not been assigned. Please assign it in the editor.");
		}
	}
	public void addPoint()
	{
		if (pointLabel != null)
		{
			points += 1;
			pointLabel.Text = points.ToString();
		}
	}

}
