from getpass import getpass

def getpassdef():
    return getpass("Write your password")

def isvscomparison(first, second):
    isresult = first is second
    comparison = first == second
    return f"'is' result is {isresult}\ncomprasion result is {comparison}"

def swapcasedef(str):
    return str.swapcase()

def sortdef(list):
    return list.sort()

def multiplystr(str, num):
    return str * num