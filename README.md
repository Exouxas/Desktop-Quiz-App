# Desktop Quiz App
Simple quiz app

## File format
The quiz app reads files of the `*.quiz` format which is a semicolon separated text file.

Each quiz file has the title of the quiz on line 1, then of each following line there are indivdual questions.

The format of the questions are:
`question text;index of the correct answer;points rewarded;negative multiplier for wrong questions;` followed by each option separated by semicolon.
