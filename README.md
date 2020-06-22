# WordsInSentence README

## Introduction
The application reads a sentence from the console and returns the longest and the shortest words in a sentence and their length.
The purpose of the excercise is to prove I might have ever written a unit test in my life.

## Task
Write a method or function in the major programming language of your choice that returns the longest word in a sentence and its length.  For example, "The cow jumped over the moon." should return "jumped" and "6". 
1. Write unit tests, reworking code as needed
2. Add a method that returns the shortest word and length with unit tests
3. Create a README documenting any assumptions you made and including instructions on how to build and execute your tests.
4. Share your code using GitHub or similar. 

## Technologies
- C#
- .NET Framework 4.6
- xUnit 2 .NET Core

## Assumptions
- A sentence can be any string entered as input.
- The application does treat "." as the end of a sentence.
- Words are understood as strings separated by single spaces, commas, dots and hyphens.
- Words can contain digits.
- Words can contain any special characters that can be entered using the keyboard.
- The application returns only a single longest and a single shortest word from a sentence.
- If there are multiple longest words, only the first longest one found, starting from the beginning of the sentence, is returned.
- If there are multiple shortest words, only the first shortest one found, starting from the beginning of the sentence, is returned.
- An exception is thrown if the input sentence is null.

## Known issues
- The application is currently not optimised to find the shortest word when sentence contains adjoining separators: spaces, commas, dots and hyphens.

## How to run the tests
1. Download and install .NET Framework and .NET Core: https://dotnet.microsoft.com/download
2. Check if the installation was successfull by typing in the command prompt (CMD, PowerShell, Bash):
```sh
$ dotnet test
```
3. Open UnitTestTask/WordsInSentence.Tests directory in the command prompt.
4. Run selected tests by typing in command prompt:
- For all tests
```sh
$ dotnet test
```
- For tests related to finding the longest word
```sh
$ dotnet test --filter Category=LongestWord
```
- For tests related to finding the shortest word
```sh
$ dotnet test --filter Category=ShortestWord
```
- For tests related to exceptions
```sh
$ dotnet test --filter Category=Exceptions
```