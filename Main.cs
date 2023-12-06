using Godot;
using Godot.Collections;
using static Main.MyStringConstants;

public partial class Main : Node
{
    public static class MyStringConstants{
        public const string USEFUL_NAME = "USEFUL_NAME";
        public const string OTHER_USEFUL_NAME = "OTHER_USEFUL_NAME";
    }

    [Export] //adding export causes error CS0103 "The name 'USEFUL_NAME' does not exist in the current context" on build
    public Dictionary MyDictionary = new()
    {
        {MyStringConstants.USEFUL_NAME, "useful_data" }, //works with export
        {OTHER_USEFUL_NAME, "other_useful_data" } // does not work with export, even though "using static Main.MyStringConstants;" is defined
    };
}