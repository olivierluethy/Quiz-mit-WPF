# Quiz mit WPF

A small German-language estimation quiz built as a Windows desktop app with C# and WPF.
The player answers five multiple-choice "guessing" questions (Christmas trees sold in
Germany, beer consumption per capita, the Hawaiian alphabet, and more) and gets a score
at the end.

## Features

- Five multiple-choice questions, each with four answer options.
- Immediate "Richtig!" / "Falsch!" feedback per question.
- A running count of correctly answered questions.
- Tab-based navigation between an intro screen and each question.

## Tech

- C# with WPF (XAML UI)
- .NET Framework 4.7.2
- Visual Studio solution (`Quiz.sln`)

## Run

Open `Quiz.sln` in Visual Studio and press **F5**, or build and run from the command line:

```bash
msbuild Quiz.sln
```

Then launch the compiled executable from `bin/`.
