from typing import List

def recursive_binary_search(numbers: List[int], x: int) -> int:
    numbersCount = len(numbers)

    if numbersCount == 0:
        return None
    
    if numbersCount == 1:
        return 0 if numbers[0] == x else None

    if numbers[0] == x:
        return 0

    if numbers[numbersCount - 1] == x:
        return numbersCount - 1
    
    mid = (numbersCount - 1) // 2

    if numbers[mid] > x:
        return recursive_binary_search(numbers[0:mid], x)
    else:
        if mid == 0:
            return None

        result = recursive_binary_search(numbers[mid:], x)
        if result == None:
            return None
        else:
            return mid + result