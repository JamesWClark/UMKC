using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_07 {
    class Heap<T> {
        private List<IComparable> data = new List<IComparable>();
        public Heap() {

        }
        public void Insert(IComparable generic) {
            data.Insert(data.Count, generic);
            int child = data.Count - 1;
            int parent = (child - 1) / 2;
            while (child > 0 && data[parent].CompareTo(generic) < 0) {
                IComparable temp = data[child];
                data[child] = data[parent];
                data[parent] = temp;
                child = parent;
                parent = (child - 1) / 2;
            }
        }
        public void Remove() {
            if (data.Count == 1) {
                data.RemoveAt(0);
                return;
            }
            IComparable temp = data[0];
            data[0] = data[data.Count - 1];
            data[data.Count - 1] = temp;
            data.RemoveAt(data.Count - 1);
            int parent = 0;
            int leftChild = 2 * parent + 1;

            while (true) {
                leftChild = 2 * parent + 1;
                if (leftChild >= data.Count) {
                    break;
                }
                int rightChild = leftChild + 1;
                int maxChild = leftChild;
                if (rightChild < data.Count && data[leftChild].CompareTo(data[rightChild]) < 0) {
                    maxChild = rightChild;
                }
                if (data[parent].CompareTo(data[maxChild]) < 0) {
                    IComparable temp2 = data[maxChild];
                    data[maxChild] = data[parent];
                    data[parent] = temp2;
                    parent = maxChild;
                } else {
                    break;
                }
            }
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            foreach (IComparable item in data) {
                sb.Append(item.ToString() + ", ");
            }
            return sb.ToString();
        }
    }
}
