#!/usr/bin/python -tt

"""
Project Euler: Problem 5
"""

import sys

def divisible_by_range(target, divisors):
  for d in divisors:
    if target % d != 0:
      return False
  return True

# Define a main() function
def main():  
  limit = int(sys.argv[1]) + 1
  divisors = range(1,limit)
  i = 1
  while True:
    if divisible_by_range(i,divisors):
      print i
      return
    else:
      i += 1
  
# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
