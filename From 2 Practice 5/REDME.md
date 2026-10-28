# Student Portal – Avalonia UI

A simple student information form built with **C# and Avalonia UI** as part of my .NET practical training. This project demonstrates form design, input validation, event handling, message dialogs, and clearing form data with user confirmation.

## Features

- **Student Information Input:** Enter the student's name and university ID.
- **Input Validation:** Checks for empty or whitespace-only fields before submission.
- **Welcome Message:** Displays a personalized welcome message when valid information is submitted.
- **Validation Feedback:** Displays a warning dialog when the student name is missing and an error message when the student ID is missing.
- **Clear Form:** Clears the entered information after the user confirms the action through a Yes/No dialog.
- **Interactive UI:** Includes styled text boxes, buttons, and hover effects.

## Technologies Used

- C#
- .NET
- Avalonia UI
- MsBox.Avalonia
- XAML

## How It Works

1. Enter the student's name and university ID.
2. Click **Submit** to validate the input.
3. If the required information is valid, the form displays a personalized welcome message.
4. Click **Clear** to display a confirmation dialog.
5. Select **Yes** to clear the form or **No** to keep the existing information.

## What I Practiced

- Handling button click events in C#.
- Accessing and updating XAML controls using `x:Name`.
- Validating input with `string.IsNullOrWhiteSpace()`.
- Using asynchronous methods with `async` and `await`.
- Displaying message boxes with `MsBox.Avalonia`.
- Applying styles to buttons and text boxes using XAML.
- Using conditional statements to control application behavior.

## Purpose

This project is part of my ongoing practice in C# and .NET application development, helping me strengthen my programming fundamentals and learn how to build interactive desktop-style forms with Avalonia UI.

---

*Built as a practical learning project.*
