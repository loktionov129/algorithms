#!/usr/bin/env python3

from random import randint
from algorithms import recursive_binary_search
from typing import List

def main():
    numbers = list(set([randint(29, 45) for _ in range(10)]))
    numbers.sort()
    x = randint(29, 45)

    result = recursive_binary_search(numbers, x)
    print("numbers:", numbers)
    print("x:", x)
    print("result:", result)

if __name__ == "__main__":
    main()
