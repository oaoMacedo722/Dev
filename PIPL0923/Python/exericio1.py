num1=2 
num2=1
num3=3

if num1>num2 and num2>num3: 
    print("o numero 1 é maior ")
elif num1>num3 and num3>num2: 
    print("numero 2 ")
elif num3>num2 and num2>num1 :
    print("Numero 1 é menor, Numero 2 é o do meio, Numero 3 é o maior")
elif num3>num1 and num1>num2: 
    print("O numero 3 é o maior o Numero 1 é o do meio, Numeor 2 é o maior")
elif num2>num1 and num1>num3:
    print("Numero 2 é o menor, numero 1 é o do meio, Numero 3 é o maior")
elif num2>num3 and num3>num1:
    print("Numero 2 é o maior Numero 3 é o do meio Numero 1 é o menor")
