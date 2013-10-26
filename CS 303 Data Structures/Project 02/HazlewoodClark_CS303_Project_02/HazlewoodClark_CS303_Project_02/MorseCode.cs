﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;

public class MorseCode : IComparable {

    private const char DASH = '–';
    private const char DOT = '*';

    public virtual Char Letter {
        get;
        set;
    }

    public virtual string Code {
        get;
        set;
    }

    public MorseCode() {
    }

    public MorseCode(Char letter, string code) {
        this.Letter = letter;
        this.Code = code;
    }

    public virtual int CompareTo(Object obj) {

        MorseCode target = (MorseCode)obj;
        
        int length = 0;

        if (this.Code.Length == target.Code.Length) {
            length = target.Code.Length;
        } else if (this.Code.Length < target.Code.Length) {
            length = this.Code.Length;
        } else {
            length = target.Code.Length;
        }
        //compare for the length of the shortest code
        for (int i = 0; i < length; i++) {
            if (this.Code[i] == target.Code[i]) {
                //do nothing, they are equal
            } else if (this.Code[i] == DOT && target.Code[i] == DASH) {
                //this one is lesser, dot < dash, go left
                return -1;
            } else {
                //last combo must be this = DASH and target = DOT, therefore go right
                return 1;
            }
        }
        throw new Exception("Can't compare these codes.");
    }

    public virtual BitArray ToBitArray() {
        int size = this.Code.Length;
        BitArray bits = new BitArray(size);
        for (int i = 0; i < size; i++) {
            switch (this.Code[i]) {
                case DASH:
                    bits[i] = true;
                    break;
                case DOT:
                    bits[i] = false;
                    break;
            }
        }
        return bits;
    }

}

