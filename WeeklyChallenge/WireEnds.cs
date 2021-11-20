namespace WeeklyChallenge;

public static class WireEnds {

	[Flags]
	public enum Direction {
		Up = 1 << 0,
		Down = 1 << 1,
		Left = 1 << 2,
		Right = 1 << 3,
		None = 0
	}

	private static Direction GetDirection(char c) =>
		c switch {
			'║' => Direction.Up | Direction.Down,
			'═' => Direction.Left | Direction.Right,
			'╚' => Direction.Up | Direction.Right,
			'╝' => Direction.Up | Direction.Left,
			'╔' => Direction.Down | Direction.Right,
			'╗' => Direction.Down | Direction.Left,
			'╠' => Direction.Up | Direction.Down | Direction.Right,
			'╣' => Direction.Up | Direction.Down | Direction.Left,
			'╩' => Direction.Left | Direction.Right | Direction.Up,
			'╦' => Direction.Left | Direction.Right | Direction.Down,
			'╬' => Direction.Up | Direction.Down | Direction.Left | Direction.Right,

			_ => Direction.None
		};

	public static int CountWireEnds(string s) {
		var grid = s
			.Split('\n')
			.Select(s => s.Select(GetDirection).ToArray())
			.ToArray();
		int height = grid.Length;

		int loose = 0;
		for (int y = 0; y < height; y++) {
			var row = grid[y];
			int width = row.Length;
			for (int x = 0; x < width; x++) {
				Direction current = row[x];
				Direction left = x == 0 ?
					Direction.None : row[x - 1];
				Direction right = x == width - 1 ?
					Direction.None : row[x + 1];
				Direction up = y == 0 || x >= grid[y - 1].Length ?
					Direction.None : grid[y - 1][x];
				Direction down = y == height - 1 || x >= grid[y + 1].Length ?
					Direction.None : grid[y + 1][x];

				if (current.HasFlag(Direction.Up) && !up.HasFlag(Direction.Down)) loose++;
				if (current.HasFlag(Direction.Down) && !down.HasFlag(Direction.Up)) loose++;
				if (current.HasFlag(Direction.Left) && !left.HasFlag(Direction.Right)) loose++;
				if (current.HasFlag(Direction.Right) && !right.HasFlag(Direction.Left)) loose++;
			}
		}

		return loose;
	}

}
