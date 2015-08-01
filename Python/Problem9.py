#!/usr/bin/python -tt

"""
Project Euler: Problem 9
https://projecteuler.net/problem=9
"""

import sys

# Define a main() function
def main():
  
  #Start with C, go from 998 down
  #Then a while loop with A incrementing from 1, B inferred, 
  # condition: while A < B
  #B = (1000 - C) - A
  
  c = 998
  while c > 0: # We shouldn't hit this condition, but if the logic fails this saves us
    
    a = 1
    b = (1000 - c) - a
      
    while a < b:
      b = (1000 - c) - a
      if ((a * a) + (b * b) == (c * c)):
        print a * b * c
        return
      a += 1
    
    c -= 1
  

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
