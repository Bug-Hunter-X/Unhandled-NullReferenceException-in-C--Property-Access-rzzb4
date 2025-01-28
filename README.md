# Unhandled NullReferenceException in C# Property Access

This repository demonstrates a common C# coding error: a `NullReferenceException` caused by accessing a property that hasn't been initialized.  The `Bug.cs` file contains the problematic code, while `BugSolution.cs` provides a corrected version.

## The Problem

In the `Bug.cs` file, the `MyProperty` of the `ExampleClass` is not initialized before being accessed in the `MyMethod`. This directly leads to a `NullReferenceException` at runtime.

## The Solution

The `BugSolution.cs` file offers two solutions to the problem:

1. **Explicit Initialization:** The property is initialized with a default value (0) in the class constructor, guaranteeing that it's never null.
2. **Null Check:** Before accessing `MyProperty`, a null check is added. If it's null, a default value or an error-handling mechanism is used. 

Both solutions prevent the `NullReferenceException`, ensuring the robustness of the code.

This example highlights the importance of proper initialization and defensive programming to avoid common runtime errors.