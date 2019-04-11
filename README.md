# Anagram Code Challenge

The objective of this code challange is to create a method that tests two strings to determine if those strings are anagrams.  The common definition of an anagram are two strings of characters that contain the same characters but perhaps in a different order.

For example, the collowing pairs of characters are anagrams:
- abc, abc
- abc, cba
- abc, bac
- abc, cab

The following pairs of characters are *not* anagrams:
- abc, aabc
- abc, aba
- abc, xxx
- abcx, abc

This challange does put further requirements on the definition of an anagram.  Namely, case-sensitivity and disallowing special characters (alphanumeric and whitespace only.)

The master branch contains an incomplete, but cleanly compilable C# .NET Core 2.2 class library project and a test project.  The challange is to make the supplied tests pass.

The Completed branch is a working solution with passing tests.  No peeking.

## What is this Testing for?
This challenge is intended to completed with a job candidate.  There does exist a simple algorith, and should be appropriate for mid or senior level devs, and perhaps with juniors with addtional guidance.

We're looking for the following:
- Does the candidate work with the paired developer well?
- Do they ask smart clarifying questions?
- How do they approach a problem?
- How do they discover an unfamiliar codebase?
- Do they understand simple unit tests and can they extract requirements from those tests?
- Do they demonstrate basic knowledge of thet .NET Framework?
- Do they code defensively checking parameters and look for exceptions?