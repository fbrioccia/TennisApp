# Game of Tennis
The game of tennis can be represented by a Tuple T(A,B,W) where:
  - A is an integer for the score of the first player
  - B is an integer for the score of the second player
  - W is an integer of value empty, 0 or 1 representing the winner 
  {Empty: no winner known yet, 0: First Player, 1: Second Player}

The logics of the game can be encoded in three functions:
  - **GameStatus: T -> String** (Returns the differents results score of the given tuple)
  - **NameScore: int -> String** (Returns the score points using the tennis scoring system)
  - **NextRound: T -> T** (Computes a new round of the match returning a new tuple updated accordingly)

  ### Technical Details
 - .Net Core 2.0.2 
 - Visual Studio Code 1.18
 - OmniSharp for Windows (.NET 4.6 / x64)