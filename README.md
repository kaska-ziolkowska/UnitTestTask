# WordsInSentence README

## Introduction
The application reads a sentence from the console and returns the longest word and the shortest words in a sentence and their length.
The purpose of the excercise is to prove I might have ever written a unit test in my life.

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

## How to run tests
- build in console
- run tests


