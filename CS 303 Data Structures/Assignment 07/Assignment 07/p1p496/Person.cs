using System;

class Person : IComparable {
    public int Dependents { get; set; }
    public Person(int dependents) {
        this.Dependents = dependents;
    }
    public int CompareTo(Object x) {
        Person person = x as Person;
        if (this.Dependents < person.Dependents) {
            return -1;
        } else if (this.Dependents == person.Dependents) {
            return 0;
        } else {
            return 1;
        }
    }
    public override string ToString() {
        return this.Dependents.ToString();
    }
}

