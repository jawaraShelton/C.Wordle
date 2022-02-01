# C.Wordle
_________     __      __                .___.__          
\_   ___ \   /  \    /  \___________  __| _/|  |   ____  
/    \  \/   \   \/\/   /  _ \_  __ \/ __ | |  | _/ __ \ 
\     \____   \        (  <_> )  | \/ /_/ | |  |_\  ___/ 
 \______  / /\ \__/\  / \____/|__|  \____ | |____/\___  >
        \/  \/      \/                   \/           \/ 
A simple game AI to play Wordle

INSTRUCTIONS:

When you load the program it will initialize, then tell you its first guess. 
Enter that guess into Wordle.

When you get the results back from Wordle, enter an x if it's a grey square, a y 
if it's a yellow square, and a g if it's a green square. Your input should look 
similar to:

  xyggy

It will then go through the list, eliminate any words that don't match the 
results, and come back with the highest-scoring word that does as its next 
guess.

Repeat the process until you get a match!

^Z
