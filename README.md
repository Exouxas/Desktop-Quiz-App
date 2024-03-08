# Desktop Quiz App
Simple quiz app

## File format
The quiz app reads files of the `*.quiz` format which is a semicolon separated text file.

Each quiz file has the title of the quiz on line 1, then of each following line there are indivdual questions.

### The format of the questions
`question text;index of the correct answer;points rewarded;negative multiplier for wrong questions;` followed by each option separated by semicolon.

### Examples
```
General Knowledge
How many dots appear on a pair of dice?;1;2;0;6;42;12;14
What planet is closest to the sun?;3;3;1;Pluto;Mars;Earth;Mercury
```
This quiz will be titled `General Knowledge`, and have the maximum score of `5` and a minimum score of `-3`. 
- The first question rewards `2` points for a right answer and `2 times 0` for a wrong answer.
- The second question rewards `3` points for a right answer and `-3 times 1` for a wrong answer.
