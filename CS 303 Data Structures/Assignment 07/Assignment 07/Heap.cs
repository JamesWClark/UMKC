using System;
using System.Collections.Generic;

namespace Assignment_07 {
    class Heap<T> {
        private List<IComparable> data = new List<IComparable>();
        public Heap() {

        }
        /*
         * template<typename Item_Type>
            void HeapTree<Item_Type>::Insert(const Item_Type &Item)
            {
            Data.push_back(Item);

            int  child = size() - 1, Parent = (child - 1) / 2;

            while ((child > 0) && (Data[Parent] < Item))  {
            std::swap(Data[child], Data[Parent]);
            child = Parent;
            Parent = (child - 1) / 2;

            }

            }

         * */
        public void Insert(IComparable generic) {
            data.Insert(data.Count - 1, generic);
            int child = data.Count - 1;
            int parent = (child - 1) / 2;
            while (child > 0 && data[parent].CompareTo(generic) < 0) {

            }
        }
        public void Remove(T generic) {

        }
    }
}
