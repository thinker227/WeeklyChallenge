namespace WeeklyChallenge;

public static class BalancedParentheses {

	public static bool AreParenthesesBalanced(string input) {
		var nums = input.Select(int? (char c) => c switch {
			'(' => 1,
			')' => -1,
			'*' => null,
			_ => 0
		});

		

		return true;
	}

}
