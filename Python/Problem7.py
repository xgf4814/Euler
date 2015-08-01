#!/usr/bin/python -tt

"""
Project Euler: Problem 7
https://projecteuler.net/problem=7
"""

import sys
import epu

# Define a main() function
def main():
  primes = []
  last_prime = long(0)
  i = 2
  limit = 10001 if (len(sys.argv) < 2) else int(sys.argv[1])
  
  while(len(primes) < limit):
    if epu.is_prime(i):
      primes.append(i)
      last_prime = i
    i += 1
    
  print last_prime
  

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
