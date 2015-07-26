#!/usr/bin/python -tt

"""
Project Euler: Problem 1
"""

import sys

# Define a main() function
def main():
  #print "This is the name of the script: ", sys.argv[0]
  #print "Number of arguments: ", len(sys.argv)
  #print "The arguments are: " , str(sys.argv)
  foo = []
  limit = int(sys.argv[1]) if (len(sys.argv) == 2) else 10;
  for x in xrange(1, limit):
    if (x % 3 == 0) or (x % 5 == 0):
      foo.append(x)
      
  sum = 0
  for y in foo:
    sum += y
    
  print(sum)

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
