--Lesson Plan 10

--C#

--Name: Xavier Kleiber

1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?

enum Ranks
{
  REC, PVT, PV2, PFC, SPC, SGT,
  SSG, SFC, MSG, MSG, FSG, SGM, SGM
}

2. Using the Ranks enum, assign a rank to yourself or a friend.
 
  Ranks John = Ranks.SPC;

3. Determine the numeric index of particular ranks, using the Ranks enum.

  Console.WriteLine((int)John);

4. How do you select the type of an enum?

enum Ranks : short 
{
  REC, PVT, PV2, PFC, SPC, SGT,
  SSG, SFC, MSG, MSG, FSG, SGM, SGM 
}

5.Are structs stored on the stack or on the heap? What about enums?
 - Both on the stack.

6. Declare a struct named DOD with four branches.

struct DoD
{
  private string army, airforce, navy, coastguard;
}

7. Why can't you create a default constructor for a struct?
 - The compiler generates one.

8. What is CIL? What does the CLR do to the CIL?
 - When you compile a C# application, the compiler converts your C# code into Common Intermediate Language (CIL). These are the instructions that are stored in an assembly. When you run a C# application, the CLR takes responsibility for converting the CIL instructions into real machine instructions that the processor on your computer can understand and execute.