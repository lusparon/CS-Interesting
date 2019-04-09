namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            for (int i = 0; i < height - 2; i++)
                robot.MoveTo(Direction.Down);
            for (int j = 0; j < width - 2; j++)
                robot.MoveTo(Direction.Right);
        }
	}
}