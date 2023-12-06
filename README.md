# godot-bug-export-attribute-CS0103
A project showing the CS0103 error when using export annotation combined with "using static" directive.

When adding the [Export] attribute to a nested static class the "using static" directive is effectively ignored on build.

![image](https://github.com/jkvastad/godot-bug-export-attribute-CS0103/assets/9295196/b188318e-87b0-44c9-967d-1261a37b9f43)

Removing it fixes the issue
![image](https://github.com/jkvastad/godot-bug-export-attribute-CS0103/assets/9295196/2ef4bcee-a5bc-4eea-9ddb-24c336541ea9)

The current workaround is to explicitly specify qualifiers.
