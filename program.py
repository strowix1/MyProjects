import time
class User:
    #storage
    global my_Users
    my_Users = []   
    def __init__(self, login, password, pin):
        self.login = login
        self.password = password
        self.pin = pin
        pass
class Funcs:
    #Globalne funkcje
    global LogAuthentication  
    global RegistrationAuthentication
    global IsLoginBlank
    global IsPasswordBlank
    global IsPinBlank
    global LoginInput
    global PasswordInput
    global PinInput
    global Shutdown
    #Autoryzacja                     
    def LogAuthentication(Asklogin : str, Askpassword : str, Askpin : int) -> bool:
        for user in my_Users:
            if user.login == Asklogin:
                if user.password == Askpassword and int(user.pin) == Askpin:
                    return True
                else:
                    return False
        return False
    def RegistrationAuthentication(Registrationlogin : str) -> bool:
            for u in my_Users:
                return u.login == Registrationlogin
    #Puste miejsca
    def IsLoginBlank(Asklogin : str) -> bool:
        return not Asklogin.strip()
    def IsPasswordBlank(Askpassword : str) -> bool:
        return not Askpassword.strip()
    #Inputy do logowania
    def LoginInput():
        while True:
            global Asklogin 
            Asklogin = input('Podaj login: ')
            if IsLoginBlank(Asklogin):
                print('\033c')
                print("Login nie moze być pusty!")
                continue
            else:
                break
    def PasswordInput():
        while True:
            global Askpassword
            Askpassword = input('Podaj hasło: ')
            if IsPasswordBlank(Askpassword):
                print('\033c')
                print("Hasło nie moze być puste!")
            else:
                break
    def PinInput():
        while True:
            try:
                global Askpin
                Askpin = int(input('Podaj PIN: '))
                break
            except ValueError:
                print('\033c')
                print('Nieprawidłowy typ')
                pass
    #Exit programu
    def Shutdown():
        t = 5
        while t:
            print("Zamkniecie za", t,  end = "\r")
            time.sleep(1)
            t -= 1
        exit()
    #Pomyslne zalogowanie
    def SuccesLogin():
        print('\033c')
        print(f"Pomyślnie zalogowano jako {Asklogin}")
        Shutdown()
#Rejestracja
def Rejestracja():
    while True:
        print('>>> Rejestracja <<<')
        while True:
            global Registrationlogin
            Registrationlogin = input('Stworz login: ')
            if IsLoginBlank(Registrationlogin):
                print('\033c')
                print("Login nie moze być pusty!")
                continue
            else:
                break
        if RegistrationAuthentication(Registrationlogin):
            print('\033c')
            print("Login jest zajęty")
            continue
        while True:
            global password
            password = input('Stworz haslo: ')
            if IsPasswordBlank(password):
                print("Hasło nie moze być puste!")
                continue
            else:
                break
        while True:
            try:
                global pin
                pin = int(input('Stworz pin: '))
                break
            except ValueError:
                print('\033c')
                print('Nieprawidłowy typ')
        #append do bazy    
        my_Users.append(User(Registrationlogin, password, pin))
        print('\033c')
        print("Zarejestrowano pomyślnie\n")
        Poczatek()
        break
#Logowanie
def Logowanie():
    #Wejście
    LoginInput()
    PasswordInput()
    PinInput()
    #Poprawne zalogowanie
    if LogAuthentication(Asklogin, Askpassword, Askpin):
        Funcs.SuccesLogin()
    #Niepoprawne zalogowanie
    else:
        #Niepoprawny login
        i = 4
        while True:
            print('\033c')
            print("Nieprawidłowy login, hasło lub pin")
            i -= 1
            if i in range(1,4):
                print(f"{' '*42} Pozostałe próby: {'i'}")
                LoginInput()
                PasswordInput()
                PinInput()
                if LogAuthentication(Asklogin, Askpassword, Askpin):
                    return Funcs.SuccesLogin()
            elif i == 0:
                print('\033c')
                print('Zbyt wiele nieudanych prób')
                Shutdown()
#Pętla główna
def Poczatek():
    while True:
        try:
            print('Strowix\' platform')
            print('1. >>> Logowanie <<<\n2. >>> Rejestracja <<<')
            enter = int(input())
            if enter == 1:
                print('\033c')
                return Logowanie()
            elif enter == 2:
                print('\033c')
                return Rejestracja()
            else:
                print('\033c')
                print('Nieprawidlowy wybor')
        except ValueError:
            print('\033c')
            print('Nieprawidłowy typ')
#Petla glowna
Poczatek()