#!/usr/bin/python -tt

"""
Project Euler: Problem 2
"""

import sys

# Define a main() function
def main():
  #print "This is the name of the script: ", sys.argv[0]
  #print "Number of arguments: ", len(sys.argv)
  #print "The arguments are: " , str(sys.argv)
  #
  #Define the previous two fibonacci numbers
  num1 = 1
  num2 = 2
  temp = 0
  result = 0
  limit = (100 if (len(sys.argv) == 1) else int(sys.argv[1]))
  
  #We want to keep generating Fib. numbers until we surpass 4 million
  while num2 < limit:
    print num2
    result += num2 if (num2 % 2 == 0) else 0
    
    temp = num1 + num2
    num1 = num2
    num2 = temp

  print "======"
  print result

# This is the standard boilerplate that calls the main() function.
if __name__ == '__main__':
  main()
