//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/Study/10-sem/iu7-compilers-course/src/Compiler/MiniJava.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class MiniJavaLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, INT=38, BOOL=39, 
		ID=40, WS=41, COMMENT=42, LINE_COMMENT=43;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "INT", "BOOL", "ID", "WS", "COMMENT", 
		"LINE_COMMENT"
	};


	public MiniJavaLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MiniJavaLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'class'", "'extends'", "'{'", "'}'", "'public'", "'static'", "'void'", 
		"'main'", "'('", "'String'", "'['", "']'", "')'", "';'", "','", "'if'", 
		"'else'", "'while'", "'System.out.println'", "'='", "'return'", "'recur'", 
		"'?'", "':'", "'.'", "'length'", "'-'", "'!'", "'new'", "'int'", "'+'", 
		"'*'", "'<'", "'&&'", "'this'", "'System.randomInt('", "'boolean'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "INT", "BOOL", "ID", "WS", "COMMENT", "LINE_COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MiniJava.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MiniJavaLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,43,321,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,
		3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,
		1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,
		10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,15,1,16,1,
		16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,18,1,
		18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,
		18,1,19,1,19,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,21,1,21,1,21,1,21,1,
		21,1,21,1,22,1,22,1,23,1,23,1,24,1,24,1,25,1,25,1,25,1,25,1,25,1,25,1,
		25,1,26,1,26,1,27,1,27,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,30,1,
		30,1,31,1,31,1,32,1,32,1,33,1,33,1,33,1,34,1,34,1,34,1,34,1,34,1,35,1,
		35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,
		35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,37,1,37,1,37,5,
		37,265,8,37,10,37,12,37,268,9,37,3,37,270,8,37,1,38,1,38,1,38,1,38,1,38,
		1,38,1,38,1,38,1,38,3,38,281,8,38,1,39,1,39,5,39,285,8,39,10,39,12,39,
		288,9,39,1,40,4,40,291,8,40,11,40,12,40,292,1,40,1,40,1,41,1,41,1,41,1,
		41,5,41,301,8,41,10,41,12,41,304,9,41,1,41,1,41,1,41,1,41,1,41,1,42,1,
		42,1,42,1,42,5,42,315,8,42,10,42,12,42,318,9,42,1,42,1,42,1,302,0,43,1,
		1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,
		15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,
		27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,
		39,79,40,81,41,83,42,85,43,1,0,6,1,0,49,57,1,0,48,57,3,0,65,90,95,95,97,
		122,4,0,48,57,65,90,95,95,97,122,3,0,9,10,13,13,32,32,2,0,10,10,13,13,
		327,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,
		0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,
		0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,
		1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,
		0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,
		1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,
		0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,
		1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,1,87,1,0,0,
		0,3,93,1,0,0,0,5,101,1,0,0,0,7,103,1,0,0,0,9,105,1,0,0,0,11,112,1,0,0,
		0,13,119,1,0,0,0,15,124,1,0,0,0,17,129,1,0,0,0,19,131,1,0,0,0,21,138,1,
		0,0,0,23,140,1,0,0,0,25,142,1,0,0,0,27,144,1,0,0,0,29,146,1,0,0,0,31,148,
		1,0,0,0,33,151,1,0,0,0,35,156,1,0,0,0,37,162,1,0,0,0,39,181,1,0,0,0,41,
		183,1,0,0,0,43,190,1,0,0,0,45,196,1,0,0,0,47,198,1,0,0,0,49,200,1,0,0,
		0,51,202,1,0,0,0,53,209,1,0,0,0,55,211,1,0,0,0,57,213,1,0,0,0,59,217,1,
		0,0,0,61,221,1,0,0,0,63,223,1,0,0,0,65,225,1,0,0,0,67,227,1,0,0,0,69,230,
		1,0,0,0,71,235,1,0,0,0,73,253,1,0,0,0,75,269,1,0,0,0,77,280,1,0,0,0,79,
		282,1,0,0,0,81,290,1,0,0,0,83,296,1,0,0,0,85,310,1,0,0,0,87,88,5,99,0,
		0,88,89,5,108,0,0,89,90,5,97,0,0,90,91,5,115,0,0,91,92,5,115,0,0,92,2,
		1,0,0,0,93,94,5,101,0,0,94,95,5,120,0,0,95,96,5,116,0,0,96,97,5,101,0,
		0,97,98,5,110,0,0,98,99,5,100,0,0,99,100,5,115,0,0,100,4,1,0,0,0,101,102,
		5,123,0,0,102,6,1,0,0,0,103,104,5,125,0,0,104,8,1,0,0,0,105,106,5,112,
		0,0,106,107,5,117,0,0,107,108,5,98,0,0,108,109,5,108,0,0,109,110,5,105,
		0,0,110,111,5,99,0,0,111,10,1,0,0,0,112,113,5,115,0,0,113,114,5,116,0,
		0,114,115,5,97,0,0,115,116,5,116,0,0,116,117,5,105,0,0,117,118,5,99,0,
		0,118,12,1,0,0,0,119,120,5,118,0,0,120,121,5,111,0,0,121,122,5,105,0,0,
		122,123,5,100,0,0,123,14,1,0,0,0,124,125,5,109,0,0,125,126,5,97,0,0,126,
		127,5,105,0,0,127,128,5,110,0,0,128,16,1,0,0,0,129,130,5,40,0,0,130,18,
		1,0,0,0,131,132,5,83,0,0,132,133,5,116,0,0,133,134,5,114,0,0,134,135,5,
		105,0,0,135,136,5,110,0,0,136,137,5,103,0,0,137,20,1,0,0,0,138,139,5,91,
		0,0,139,22,1,0,0,0,140,141,5,93,0,0,141,24,1,0,0,0,142,143,5,41,0,0,143,
		26,1,0,0,0,144,145,5,59,0,0,145,28,1,0,0,0,146,147,5,44,0,0,147,30,1,0,
		0,0,148,149,5,105,0,0,149,150,5,102,0,0,150,32,1,0,0,0,151,152,5,101,0,
		0,152,153,5,108,0,0,153,154,5,115,0,0,154,155,5,101,0,0,155,34,1,0,0,0,
		156,157,5,119,0,0,157,158,5,104,0,0,158,159,5,105,0,0,159,160,5,108,0,
		0,160,161,5,101,0,0,161,36,1,0,0,0,162,163,5,83,0,0,163,164,5,121,0,0,
		164,165,5,115,0,0,165,166,5,116,0,0,166,167,5,101,0,0,167,168,5,109,0,
		0,168,169,5,46,0,0,169,170,5,111,0,0,170,171,5,117,0,0,171,172,5,116,0,
		0,172,173,5,46,0,0,173,174,5,112,0,0,174,175,5,114,0,0,175,176,5,105,0,
		0,176,177,5,110,0,0,177,178,5,116,0,0,178,179,5,108,0,0,179,180,5,110,
		0,0,180,38,1,0,0,0,181,182,5,61,0,0,182,40,1,0,0,0,183,184,5,114,0,0,184,
		185,5,101,0,0,185,186,5,116,0,0,186,187,5,117,0,0,187,188,5,114,0,0,188,
		189,5,110,0,0,189,42,1,0,0,0,190,191,5,114,0,0,191,192,5,101,0,0,192,193,
		5,99,0,0,193,194,5,117,0,0,194,195,5,114,0,0,195,44,1,0,0,0,196,197,5,
		63,0,0,197,46,1,0,0,0,198,199,5,58,0,0,199,48,1,0,0,0,200,201,5,46,0,0,
		201,50,1,0,0,0,202,203,5,108,0,0,203,204,5,101,0,0,204,205,5,110,0,0,205,
		206,5,103,0,0,206,207,5,116,0,0,207,208,5,104,0,0,208,52,1,0,0,0,209,210,
		5,45,0,0,210,54,1,0,0,0,211,212,5,33,0,0,212,56,1,0,0,0,213,214,5,110,
		0,0,214,215,5,101,0,0,215,216,5,119,0,0,216,58,1,0,0,0,217,218,5,105,0,
		0,218,219,5,110,0,0,219,220,5,116,0,0,220,60,1,0,0,0,221,222,5,43,0,0,
		222,62,1,0,0,0,223,224,5,42,0,0,224,64,1,0,0,0,225,226,5,60,0,0,226,66,
		1,0,0,0,227,228,5,38,0,0,228,229,5,38,0,0,229,68,1,0,0,0,230,231,5,116,
		0,0,231,232,5,104,0,0,232,233,5,105,0,0,233,234,5,115,0,0,234,70,1,0,0,
		0,235,236,5,83,0,0,236,237,5,121,0,0,237,238,5,115,0,0,238,239,5,116,0,
		0,239,240,5,101,0,0,240,241,5,109,0,0,241,242,5,46,0,0,242,243,5,114,0,
		0,243,244,5,97,0,0,244,245,5,110,0,0,245,246,5,100,0,0,246,247,5,111,0,
		0,247,248,5,109,0,0,248,249,5,73,0,0,249,250,5,110,0,0,250,251,5,116,0,
		0,251,252,5,40,0,0,252,72,1,0,0,0,253,254,5,98,0,0,254,255,5,111,0,0,255,
		256,5,111,0,0,256,257,5,108,0,0,257,258,5,101,0,0,258,259,5,97,0,0,259,
		260,5,110,0,0,260,74,1,0,0,0,261,270,5,48,0,0,262,266,7,0,0,0,263,265,
		7,1,0,0,264,263,1,0,0,0,265,268,1,0,0,0,266,264,1,0,0,0,266,267,1,0,0,
		0,267,270,1,0,0,0,268,266,1,0,0,0,269,261,1,0,0,0,269,262,1,0,0,0,270,
		76,1,0,0,0,271,272,5,116,0,0,272,273,5,114,0,0,273,274,5,117,0,0,274,281,
		5,101,0,0,275,276,5,102,0,0,276,277,5,97,0,0,277,278,5,108,0,0,278,279,
		5,115,0,0,279,281,5,101,0,0,280,271,1,0,0,0,280,275,1,0,0,0,281,78,1,0,
		0,0,282,286,7,2,0,0,283,285,7,3,0,0,284,283,1,0,0,0,285,288,1,0,0,0,286,
		284,1,0,0,0,286,287,1,0,0,0,287,80,1,0,0,0,288,286,1,0,0,0,289,291,7,4,
		0,0,290,289,1,0,0,0,291,292,1,0,0,0,292,290,1,0,0,0,292,293,1,0,0,0,293,
		294,1,0,0,0,294,295,6,40,0,0,295,82,1,0,0,0,296,297,5,47,0,0,297,298,5,
		42,0,0,298,302,1,0,0,0,299,301,9,0,0,0,300,299,1,0,0,0,301,304,1,0,0,0,
		302,303,1,0,0,0,302,300,1,0,0,0,303,305,1,0,0,0,304,302,1,0,0,0,305,306,
		5,42,0,0,306,307,5,47,0,0,307,308,1,0,0,0,308,309,6,41,0,0,309,84,1,0,
		0,0,310,311,5,47,0,0,311,312,5,47,0,0,312,316,1,0,0,0,313,315,8,5,0,0,
		314,313,1,0,0,0,315,318,1,0,0,0,316,314,1,0,0,0,316,317,1,0,0,0,317,319,
		1,0,0,0,318,316,1,0,0,0,319,320,6,42,0,0,320,86,1,0,0,0,8,0,266,269,280,
		286,292,302,316,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}