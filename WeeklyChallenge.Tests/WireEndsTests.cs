﻿namespace WeeklyChallenge.Tests;

public sealed class WireEndsTests {
	
	[Fact]
	public void Sample() {
		Assert.Equal(4, WireEnds.CountWireEnds("" +
			"╔══╗\n" +
			"║╚╝║\n" +
			"║╔╗║\n" +
			"╚══╝"));
		Assert.Equal(2, WireEnds.CountWireEnds("" +
			"║╔╗║\n" +
			"║║║║\n" +
			"║║║║\n" +
			"╚╝╚╝"));
		Assert.Equal(0, WireEnds.CountWireEnds("" +
			" ╔╗\n" +
			"╔╝╚═╗\n" +
			"╚╗  ╚═╗\n" +
			" ╚════╝"));
	}

	[Fact]
	public void Extended() {
		(string Input, int Output)[] testCases = {
			(
				"", 0
			),
			(
				" ", 0
			),
			(
				"║", 2
			),
			(
				"╠", 3
			),
			(
				"╩", 3
			),
			(
				"╦", 3
			),
			(
				"═", 2
			),
			(
				"╬", 4
			),
			(
				"╣", 3
			),
			(
				"╚", 2
			),
			(
				"╝", 2
			),
			(
				"╔", 2
			),
			(
				"╗", 2
			),
			("║╠╩╦═╬╣╚╝╔╗ ", 14),

			(
				"╔╦╦══╦╗\n" +
				"║╠╩╦═╬╣\n" +
				"╚╩═╩═╩╝\n",
				0
			),
			(
				"║╔╗║\n" +
				"║║║║\n" +
				"║║║║\n" +
				"╚╝╚╝",
				2
			),
			(
				"╔══╗\n" +
				"║╔╗║\n" +
				"║╚╝║\n" +
				"╚══╝",
				0
			),
			(
				"╔╦╦╗\n" +
				"╠╬╬╣\n" +
				"╠╬╬╣\n" +
				"╚╩╩╝",
				0
			),
			(
				"╔══╗\n" +
				"║╬╬║\n" +
				"║╬╬║\n" +
				"╚══╝",
				8
			),
			(
				"╔══╗\n" +
				"║╚╝║\n" +
				"║╔╗║\n" +
				"╚══╝",
				4
			),
			(
				" ╔╗\n" +
				"╔╝╚═╗\n" +
				"╚╗  ╚═╗\n" +
				" ╚════╝",
				0
			),
			(
				" ╔╗\n" +
				"╔╝╚╦╗\n" +
				"╚╦═╣╚═╗\n" +
				" ╚═╩══╝",
				0
			),
			(
				" ╔╗\n" +
				"╔╝╚╦╗\n" +
				"╚╦  ╚═╗\n" +
				" ╚═╩══╝",
				3
			),
			(
				"╔═════════╗\n" +
				"╚═╗       ║\n" +
				"  ╚═╗     ║\n" +
				"    ╚═╗   ║\n" +
				"      ╚═╗ ║\n" +
				"        ╚═╝\n",
				0
			),
			(
				"╔════╦══╦═╗\n" +
				"╚═╗  ╚╗ ╚═╣\n" +
				"  ╚═╗ ╚═╗ ║\n" +
				"    ╚═╗ ╚═╣\n" +
				"      ╚═╗ ║\n" +
				"        ╚═╝\n",
				0
			),
			(
				"╔ ═ ═╦══ ═ \n" +
				" ═╗   ╗ ╚ ╣\n" +
				"   ═╗  ═  ║\n" +
				"     ═╗ ╚  \n" +
				"       ═╗  \n" +
				"         ═╝\n",
				30
			),
			(
				"╔═══════════════════╦═══════════════════╗\n" +
				"║                   ║                   ║\n" +
				"║   ╔═╗   ╔═════╗   ║   ╔═════╗   ╔═╗   ║\n" +
				"║   ╚═╝   ╚═════╝   ║   ╚═════╝   ╚═╝   ║\n" +
				"║                                       ║\n" +
				"║   ═══   ║   ══════╦══════   ║   ═══   ║\n" +
				"║         ║         ║         ║         ║\n" +
				"╚═════╗   ╠══════   ║   ══════╣   ╔═════╝\n" +
				"      ║   ║                   ║   ║      \n" +
				"══════╝   ║   ╔════   ════╗   ║   ╚══════\n" +
				"              ║           ║              \n" +
				"══════╗   ║   ║           ║   ║   ╔══════\n" +
				"      ║   ║   ╚═══════════╝   ║   ║      \n" +
				"      ║   ║                   ║   ║      \n" +
				"╔═════╝   ║   ══════╦══════   ║   ╚═════╗\n" +
				"║                   ║                   ║\n" +
				"║   ══╗   ═══════   ║   ═══════   ╔══   ║\n" +
				"║     ║                           ║     ║\n" +
				"╠══   ║   ║   ══════╦══════   ║   ║   ══╣\n" +
				"║         ║         ║         ║         ║\n" +
				"║   ══════╩══════   ║   ══════╩══════   ║\n" +
				"║                                       ║\n" +
				"╚═══════════════════════════════════════╝",
				46
			),
		};

		foreach (var (input, expected) in testCases) {
			int actualOutput = WireEnds.CountWireEnds(input);
			Assert.Equal(expected, actualOutput);
		}
	}

}
