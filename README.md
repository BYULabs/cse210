# CSE210 - Programming Course Repository

This repository contains a collection of C# projects for the CSE210 (Computer Science and Engineering) course. It includes exercises, assignments, and projects covering object-oriented programming concepts, design patterns, and practical application development.

> **Note**: This repository is cloned from the official template repository: [byui-cse/cse210-ww-student-template](https://github.com/byui-cse/cse210-ww-student-template)

## Repository Structure

The repository is organized by week, with each week containing one or more projects:

```
cse210/
├── sandbox/          # Sandbox project for experimentation
├── week01/           # Basic C# exercises
├── week02/           # Object-oriented concepts
├── week03/           # Object-oriented design
├── week04/           # Advanced OOP concepts
├── week05/           # Design principles and patterns
├── week06/           # Polymorphism and inheritance
├── week07/           # Advanced topics
└── README.md
```

## Projects Overview

### Sandbox
- **Purpose**: Experimental project for testing and learning
- **Project**: `sandbox/Sandbox/`

### Week 01 - Programming Basics
Entry-level exercises covering C# fundamentals:
- **Exercise1** - Basic console output and variables
- **Exercise2** - Control flow and conditionals
- **Exercise3** - Loops and iteration
- **Exercise4** - Methods and functions
- **Exercise5** - Arrays and collections

### Week 02 - Object-Oriented Programming Fundamentals
Introduction to OOP concepts:
- **Journal** - Create a simple journal application with entries and persistence
- **Resumes** - Build a resume management system showcasing encapsulation

### Week 03 - Object-Oriented Design
Deeper dive into class design and relationships:
- **Fractions** - Implement a Fraction class with mathematical operations
- **ScriptureMemorizer** - Scripture memorization tool with text processing

### Week 04 - Inheritance and Polymorphism
Working with inheritance hierarchies:
- **YouTubeVideos** - Video management system with categorization
- **OnlineOrdering** - E-commerce ordering system with products and orders

### Week 05 - Abstraction and Interfaces
Designing with abstract classes and interfaces:
- **Homework** - Homework tracking and management application
- **Mindfulness** - Mindfulness activities tracker with different activity types

### Week 06 - Advanced OOP Concepts
Complex inheritance and polymorphic behaviors:
- **Shapes** - Geometric shape hierarchy with area and perimeter calculations
- **EternalQuest** - Goal tracking system with different goal types and rewards

### Week 07 - Advanced Topics
Capstone projects and complex systems:
- **ExerciseTracking** - Exercise logging and statistics tracking application

## Prerequisites

- **.NET SDK** 6.0 or higher
- **C# 10** or compatible version
- **Visual Studio Code** or **Visual Studio** (optional but recommended)

## Building and Running Projects

### Build All Projects
```bash
dotnet build
```

### Build a Specific Project
```bash
dotnet build week01/Exercise1/Exercise1.csproj
```

### Run a Specific Project
```bash
dotnet run --project week01/Exercise1/Exercise1.csproj
```

### Using the Solution File
You can also open the solution file in Visual Studio:
```bash
cse210-ww-student-template.sln
```

## Available Build Tasks

The following tasks are available in VS Code:
- `build-sandbox-Sandbox`
- `build-week01-Exercise1` through `build-week01-Exercise5`
- `build-week02-Journal` and `build-week02-Resumes`
- `build-week03-Fractions` and `build-week03-ScriptureMemorizer`
- `build-week04-YouTubeVideos` and `build-week04-OnlineOrdering`
- `build-week05-Homework` and `build-week05-Mindfulness`
- `build-week06-Shapes` and `build-week06-EternalQuest`
- `build-week07-ExerciseTracking`

## Key Learning Objectives

Throughout this course, students will learn:

- **Object-Oriented Programming**: Classes, objects, inheritance, polymorphism
- **SOLID Principles**: Single responsibility, Open/closed, Liskov substitution, Interface segregation, Dependency inversion
- **Design Patterns**: Implementing common design patterns in C#
- **Data Structures**: Working with collections and managing data
- **Encapsulation**: Information hiding and access modifiers
- **Real-world Applications**: Building practical programs with user interaction and data persistence

## Development Workflow

1. Navigate to the specific project folder
2. Open `Program.cs` to view and modify the main entry point
3. Build the project using `dotnet build`
4. Run the project using `dotnet run`
5. Iterate on the implementation based on requirements

## Notes

- Each project is a standalone console application
- Projects demonstrate incremental complexity as you progress through the course
- Focus on understanding OOP principles and design patterns
- Follow best practices for code organization and clarity

## License

This repository is for educational purposes as part of the CSE210 course.

---

**Last Updated**: February 2026
