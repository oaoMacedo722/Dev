opc= 0

print("Bem vindo")
print("Prima 1 para o nome cliente")
print("Prima 2 para Iban")
opc=input("Intruduza opção: ")

match opc: 
    case 1: 
        print("nome")
    case 2:
        print("Iban")
    case default:
        print("falhou")


#entre 3 numeros saber o maior, meio e menor

num1=0
num2=0
num3=0


if num1>num2 and num2>num3 :
        print("Numero 1 é o maior Numero 2 é o do meio Numero 3 é o menor")