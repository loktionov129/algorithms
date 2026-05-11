from random import randint
from unittest import TestCase
from algorithms import recursive_binary_search

class BinarySearchTest(TestCase):
    def test_search_in_empty_list_expect_none(self):
        numbers = []
        x = 42
        actual = recursive_binary_search(numbers, x)
        expected = None
        self.assertEqual(actual, expected)

    def test_search_42_expect_zero(self):
        numbers = [42]
        x = 42
        actual = recursive_binary_search(numbers, x)
        expected = 0
        self.assertEqual(actual, expected)

    def test_search_137_expect_none(self):
        numbers = [42]
        x = 137
        actual = recursive_binary_search(numbers, x)
        expected = None
        self.assertEqual(actual, expected)

    def test_search_among_two_values_expect_0(self):
        numbers = [56, 79]
        x = 56
        actual = recursive_binary_search(numbers, x)
        expected = 0
        self.assertEqual(actual, expected)

    def test_search_among_two_values_expect_1(self):
        numbers = [56, 79]
        x = 79
        actual = recursive_binary_search(numbers, x)
        expected = 1
        self.assertEqual(actual, expected)

    def test_search_2_expect_0(self):
        numbers = [2, 4, 34, 42, 99]
        x = 2
        actual = recursive_binary_search(numbers, x)
        expected = 0
        self.assertEqual(actual, expected)

    def test_search_4_expect_1(self):
        numbers = [2, 4, 34, 42, 99]
        x = 4
        actual = recursive_binary_search(numbers, x)
        expected = 1
        self.assertEqual(actual, expected)

    def test_search_34_expect_2(self):
        numbers = [2, 4, 34, 42, 99]
        x = 34
        actual = recursive_binary_search(numbers, x)
        expected = 2
        self.assertEqual(actual, expected)

    def test_search_42_expect_3(self):
        numbers = [2, 4, 34, 42, 99]
        x = 42
        actual = recursive_binary_search(numbers, x)
        expected = 3
        self.assertEqual(actual, expected)

    def test_search_99_expect_4(self):
        numbers = [2, 4, 34, 42, 99]
        x = 99
        actual = recursive_binary_search(numbers, x)
        expected = 4
        self.assertEqual(actual, expected)

    def test_too_hard(self):
        numbers = list(set([randint(29, 45) for _ in range(10)]))
        numbers.sort()
        for index, item in enumerate(numbers):
            with self.subTest(index = index, item = item, numbers = numbers):
                actual = recursive_binary_search(numbers, item)
                expected = index
                self.assertEqual(actual, expected)