# enterprise-testing-starter
The name is misleading -- this isn't exactly an enterprise solution or even a simulation of one. But it's not exactly a one-file FizzBuzz either, y'know?

## Purpose

Once upon a time a guy had a dream. He wanted to introduce unit testing to his team. Yet the framework the application is built on -- you know the type, everything abstracted from view, tightly coupled together behind a curtain put up by some overly-clever developer -- does not lend itself to the usual "Here's how to test" => "We can immediately practice on the next card" approach.

This repo is for collecting sample code that fit a pretty specific scenario, where I need to tailor some instruction to fresh eyes working in a legacy stack with existing patterns.

## Solutions

There's only one as of 20250425, but let's pretend I'll add more over time.

### GameTools

This is a couple class libraries that we will pretend are part of a larger RPG game engine. It's a take on the classic calculator exercise we see a lot of in "learn to TDD" circles.

#### Depenencies

- .NET Framework 4.8
- MSTest 2.2.1
- Shouldly 4.3.0
- Moq 4.20.72

#### Running

The target audience will be cloning the repor then running this in Visual Studio, but standard `dotnet` CLI commands should work fine.