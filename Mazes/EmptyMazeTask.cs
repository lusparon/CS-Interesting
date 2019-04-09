namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            MoveDownOnCount(robot,height-3);
            MoveRightOnCount(robot,width-3);
        }

        public static void MoveDownOnCount(Robot robot, int count)
        {
            for (int i = 1; i <= count ; i++)
                robot.MoveTo(Direction.Down);
        }

        public static void MoveRightOnCount(Robot robot, int count)
        {
            for (int i = 1; i <= count ; i++)
                robot.MoveTo(Direction.Right);
        }
    }
}