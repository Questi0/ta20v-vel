while True:
    print('Для выхода введите : z')
    S1=input("Из какой системы --> ")
    if S1 == 'z':
        break
    elif S1 == '2' or S1 == '8' or S1 == '10' or S1 == '16':
        S1 = int(S1) 
    else:
        print('Не верно! Выберите 2, 8, 10 или 16')
        continue

    S2=input("В какую систему --> ")

    if S2 == 'q':
        break
    elif S2 == '2' or S2 == '8' or S2 == '10' or S2 == '16':
        S2 = int(S2) 
    else:
        print('Выберите 10, 8, 2 или 16')
        continue
    
    while True:
        t=input("Введите число --> ")
        t = t.lower()

      #Проверки
        def Proverka2(tt):
            b=True
            for s in tt:
                if (s!='0' and s!='1'):
                    b=False
            return b

        def Proverka8(tt):
            b=True
            for s in tt:
                if (s!='0' and s!='1' and s!='3' and s!='4' and s!='5' and s!='6' and s!='7'):
                    b=False
            return b

        def Proverka10(tt):
            b=True
            for s in tt:
                if (s!='0' and s!='1' and s!='2' and s!='3' and s!='4' and s!='5' 
                and s!='6' and s!='7' and s!='8' and s!='9' and s!='10'):
                    b=False
            return b

        def Proverka16(tt):
            b=True
            for s in tt:
                if (s!='0' and s!='1' and s!='3' and s!='4' and s!='5' 
                and s!='6' and s!='7' and s!='8' and s!='9'and s!='a' 
                and s!='b' and s!='c' and s!='d' and s!='e' and s!='f'):
                    b=False
            return b

        # Проверка этого числа на правильность в его системе счисления
        if (S1==2):
            b=Proverka2(t)
        elif (S1==8):
            b=Proverka8(t)
        elif (S1==10):
            b=Proverka10(t)
        elif (S1==16):
            b=Proverka16(t)
        else:
            b=print('Wrong!')

        if b:
            break
        else:
            print('--------------------------------------------------')
            print('Введенное число не соответсвует системе счисления')
            print('Вводите правильно!')
            print('--------------------------------------------------')
            continue
    

    def Perevod_2_10(tt):
        n10=0   
        for s in tt:
            k=int(s)
            n10=n10*2+k
        return n10

    def Perevod_8_10(tt):
        n10=0
        for s in tt:
            k=int(s)
            n10=n10*8+k
        return n10

    def Perevod_16_10(tt):
        nums = []
        j = 0
        summ = 0
        for s in (tt):
            s = s.replace("a", "10")
            s = s.replace("b", "11")
            s = s.replace("c", "12")
            s = s.replace("d", "13")
            s = s.replace("e", "14")
            s = s.replace("f", "15")
            nums.append(s)
        for s in nums[::-1]:
            #print(s) 
            num = int(s) * 16 ** j
            summ = summ + num
            j = j + 1
        return summ
    
    def Perevod_10_2(tt):
        n10=int(tt)
        t2=""
        while (n10>0):
            ostatok=n10%2
            t2=str(ostatok)+t2
            n10=n10//2
        return t2

    def Perevod_10_8(tt):
        n8= 0
        ctr = 0
        ostatok = int(tt)
        while(ostatok > 0):
            n8 += ((ostatok%8)*(10**ctr))
            ostatok = int(ostatok/8)
            ctr += 1
        return n8

    def Perevod_10_16(tt):
        summ = []
        num = []
        tt = int(tt)
        while tt >= 15:
            j = tt % 16
            summ.append(str(j))
            tt = tt // 16
        summ.append(str(tt))
        for i in summ:
            i = i.replace("10", "a")
            i = i.replace("11", "b")
            i = i.replace("12", "c")
            i = i.replace("13", "d")
            i = i.replace("14", "e")
            i = i.replace("15", "f")
            num.append(i)
        num = "".join(num)
        return num[::-1]


    if (S1==2 and S2==10):
        rez=Perevod_2_10(t)
    elif (S1==2 and S2==8):
        rez=Perevod_10_8(Perevod_2_10(t))
    elif (S1==2 and S2==16):
        rez=Perevod_10_16(Perevod_2_10(t))
    elif (S1==2 and S2==2):
        rez=t
    # 8
    elif (S1==8 and S2==2):
        rez=Perevod_10_2(Perevod_8_10(t))
    elif (S1==8 and S2==10):
        rez=Perevod_8_10(t)
    elif (S1==8 and S2==16):
        rez=Perevod_10_16(Perevod_8_10(t))
    elif (S1==8 and S2==8):
        rez=t
    # 10
    elif (S1==10 and S2==2):
        rez=Perevod_10_2(t)
    elif (S1==10 and S2==8):
        rez=Perevod_10_8(t)
    elif (S1==10 and S2==16):
        rez=Perevod_10_16(t)
    elif (S1==10 and S2==10):
        rez=t
    # 16
    elif (S1==16 and S2==2):
        rez=Perevod_10_2(Perevod_16_10(t))
    elif (S1==16 and S2==8):
        rez=Perevod_10_8(Perevod_16_10(t))
    elif (S1==16 and S2==10):
        rez=Perevod_16_10(t)
    elif (S1==16 and S2==16):
        rez=t

    print('-------------------------')
    print('Результат равен ' + str(rez))
    print('-------------------------')