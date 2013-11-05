using System;
using System.Collections;

class PersonComparer : IComparer {
    public int Compare(Object x, Object y) {
        Person a = x as Person;
        Person b = y as Person;
        if (a.Dependents < b.Dependents) {
            return -1;
        } else if (a.Dependents == b.Dependents) {
            return 0;
        } else {
            return 1;
        }
    }
}

