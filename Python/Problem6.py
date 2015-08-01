#!/usr/bin/python -tt

"""
Project Euler: Problem 6
"""

import sys

def sum_of_squares(limit):
  acc = long(0)
  for x in range(1,limit+1):
    acc += (x * x)
  return acc

def square_of_sums(limit):
  acc = long(0)
  for x in range(1,limit+1):
    acc += x
  acc = acc * acc
  return acc

# Define a main() function
def main():
  limit = long(100) if len(sys.argv) < 2 else long(sys.argv[1])
  x = sum_of_squares(limit)
  y = square_of_sums(limit)
  z = y - x
  print "For the first " + str(limit) + " natural numbers;"
  print "Sum of squares: " + str(x)
  print "Square of sums: " + str(y)
  print "Difference:     " + str(z)

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
