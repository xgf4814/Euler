#!/usr/bin/python -tt

"""
Project Euler Utils
"""

def step_up_range(start, end, step):
  while start <= end:
    yield start
    start += step

def step_down_range(start, end, step):
  while start >= end:
    yield start
    start -= step

def is_prime(p):
  for i in range(2,p):
    if p % i == 0:
      return False
  return True

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  print "This is a library and has no function on its own."
