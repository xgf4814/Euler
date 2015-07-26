#!/usr/bin/python -tt

"""
Project Euler: Problem 3
"""

import sys

# Define a main() function
def main():
  #print "This is the name of the script: ", sys.argv[0]
  #print "Number of arguments: ", len(sys.argv)
  #print "The arguments are: " , str(sys.argv)
  factors = []
  target = long(sys.argv[1])
  print target
  i = long(2)
  while target > 1:
    if (target % i == 0):
      target = target / i;
      factors.append(i)
      print i;
    else: 
      i += 1

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
