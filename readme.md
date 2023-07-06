# C# Value Type Memory Allocation

## Stack 

- value type is declared as an argument in method

- value type is declared as local variable in method

- ref struct is always allocated in stack memory

- once outside the current method, value type allocated in stack memory is poped, no garage collection is needed, then value type of next method is allocated in the same stack memory address, the stack memory is reused


## Heap 

- value type is declared as member in a class (stored with its parent class)

