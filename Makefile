#Makefile script for C# Practice 4


Main: *.cs
	@mcs *.cs

edit:
	@vim MainClass.cs

run:
	@mono *.exe

clean:
	@rm *.exe
