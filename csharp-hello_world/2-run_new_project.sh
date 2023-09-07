#!/usr/bin/env bash

#Define project director
project_dir="2-new_project"

mkdir -p "$project_dir"

cd $project_dir

dotnet new console

dotnet build

dotnet run 

# Make sure all files end with a newline character
find . -type f -exec sed -i -e '$a\' {} \;

# Make all shell scripts executable
chmod +x Program.cs