using System;
using System.Collections;

class PersonComparer : IComparer {
    public int Compare(Object x, Object y) {
        Person a = (Person)x;
        Person b = (Person)y;
        if (a.Dependents < b.Dependents) {
            return -1;
        } else if (a.Dependents == b.Dependents) {
            return 0;
        } else {
            return 1;
        }
    }
}

