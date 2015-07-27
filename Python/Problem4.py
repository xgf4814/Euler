#!/usr/bin/python -tt

"""
Project Euler: Problem 3
"""

import sys
import epu

def palindrome(product):
  s = str(product)
  c = list(s)
  
  l = len(s)
  if l % 2 != 0:
    l -= 1
  
  i = 0
  while i <= ((l / 2) - 1):
    if (c[i] != c[(len(s)-1)-i]):
      return False
    i += 1
  
  return True
  

# Define a main() function
def main():
  #print "This is the name of the script: ", sys.argv[0]
  #print "Number of arguments: ", len(sys.argv)
  #print "The arguments are: " , str(sys.argv)
  palindromes = []
  product = 0
  
  for i in epu.step_down_range(999,100,1):
    for j in epu.step_down_range(999,100,1):
      product = i * j
      if palindrome(product):
        palindromes.append(product)
        
  largest = 0
  for p in palindromes:
    if p > largest:
      largest = p
  
  print largest

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
