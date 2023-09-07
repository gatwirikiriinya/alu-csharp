#!/usr/bin/env bash

# Create a directory for the new C# project
mkdir -p 1-new_project

# Change into the project directory
cd 1-new_project

# Initialize a new C# project using dotnet
dotnet new console

# Build the C# project
dotnet build

# Make sure all files end with a newline character
find . -type f -exec sed -i -e '$a\' {} \;

# Make all shell scripts executable
chmod +x Program.cs