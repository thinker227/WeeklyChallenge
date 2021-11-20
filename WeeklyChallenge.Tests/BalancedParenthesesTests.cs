namespace WeeklyChallenge.Tests;

public sealed class BalancedParenthesesTests {

	[Fact]
	public void Tests() {
		Assert.True(BalancedParentheses.AreParenthesesBalanced("(()*"));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("(*)"));
		Assert.False(BalancedParentheses.AreParenthesesBalanced(")*("));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("((()))"));
		Assert.False(BalancedParentheses.AreParenthesesBalanced(")))(("));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("(*"));
		Assert.False(BalancedParentheses.AreParenthesesBalanced("))***"));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("(*)(*)))*"));
		Assert.False(BalancedParentheses.AreParenthesesBalanced("*)("));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("((**)"));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("(*))"));
		Assert.False(BalancedParentheses.AreParenthesesBalanced("*("));
		Assert.True(BalancedParentheses.AreParenthesesBalanced("(*()"));
	}

}
