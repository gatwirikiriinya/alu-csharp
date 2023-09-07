#!/usr/bin/env bash

# Create a directory for the new C# project
mkdir -p 0-new_project

# Change into the project directory
cd 0-new_project

# Initialize a new C# project using dotnet
dotnet new console

# This will create a basic console application template

# Make sure all files end with a newline character
find . -type f -exec sed -i -e '$a\' {} \;

# Make all shell scripts executable
chmod +x Program.cs
