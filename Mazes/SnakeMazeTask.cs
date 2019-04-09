namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            int i = 1;
            while (i < height-2)
            {
                RightDownLeftStep(robot,width);
                i += 2;
                if (i != height-2)
                {
                    EmptyMazeTask.MoveDownOnCount(robot, 2);
                    i += 2;
                }
            }
		}

        public static void MoveLeftOnCount(Robot robot, int count)
        {
            for (int i = 1; i <= count; i++)
                robot.MoveTo(Direction.Left);
        }

        public static void RightDownLeftStep(Robot robot, int width)
        {
            EmptyMazeTask.MoveRightOnCount(robot, width - 3);
            EmptyMazeTask.MoveDownOnCount(robot, 2);
            MoveLeftOnCount(robot, width - 3);
        }
    }
}