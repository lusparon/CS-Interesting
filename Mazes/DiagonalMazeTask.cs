namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            int rightshift = 0;
            int downshift = 0;
            RightAndDownShifts(robot,width,height,out rightshift,out downshift);
            if (width > height)
                ShiftIfWidthMoreHeight(robot, width, height, rightshift, downshift);
            else
            if (width < height)
                ShiftIfWidthLessHeight(robot, width, height, rightshift, downshift);
        }

        public static void RightAndDownShifts(Robot robot, int width, int height, out int rightshift, out int downshift)
        {
            rightshift = 0;
            downshift = 0;
            if (width > height)
            {
                rightshift = (width - 3) / (height - 2);
                downshift = 1;
            }
            else
            if (width < height)
            {
                rightshift = 1;
                downshift = (height - 3) / (width - 2);
            }
        }

        public static void ShiftIfWidthLessHeight(Robot robot, int width, int height, int rightshift, int downshift)
        {
            for (int i = 0; i < width - 3; i++)
            {
                EmptyMazeTask.MoveDownOnCount(robot, downshift);
                EmptyMazeTask.MoveRightOnCount(robot, rightshift);
            }
            EmptyMazeTask.MoveDownOnCount(robot, downshift);
        }

        public static void ShiftIfWidthMoreHeight(Robot robot, int width, int height, int rightshift, int downshift)
        {
            for (int i = 0; i < height - 3; i++)
            {
                EmptyMazeTask.MoveRightOnCount(robot, rightshift);
                EmptyMazeTask.MoveDownOnCount(robot, downshift);
            }
            EmptyMazeTask.MoveRightOnCount(robot, rightshift);
        }
    }
}