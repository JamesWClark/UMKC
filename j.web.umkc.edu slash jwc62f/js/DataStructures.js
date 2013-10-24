/* LINKED LIST */

//default constructor
function LinkedList() {
	return {
		Count: 0,
		First: null,
		Last: null,
		AddFirst: function(value) {
			var node = LinkedListNode(value);
			node.Next = this.First;
			node.LinkedList = this;
			this.First = node;
			node.Next.Previous = node;
			this.Count++;
			if(this.Last === null) {
				this.Last = node;
			}
		},
		AddLast: function(value) {
			var node = LinkedListNode(value);			
			node.Previous = this.Last;
			this.Last = node;
			node.Previous.Next = node;
			node.LinkedList = this;
			this.Count++;
			if(this.First === null) {
				this.First = node;
			}
		},
		ElementAt: function(index) {
			var node = this.First;
			for(var i = 1; i < index; i++) {
				node = node.Next;
			}
			return node.Value;
		},
		Remove: function(node) {
			if(node === this.First) {
				this.First = node.Next;
				//delete(node);
			} else if(node === this.Last) {
				this.Last = node.Previous;
				//delete(node);
			} else {
				var prev = node.Previous;
				var next = node.Next;
				next.Prev = prev;
				prev.Next = next;
				//delete(node);
			}
			this.Count--;
		}
	}
}

/* LINKED LIST NODE */
function LinkedListNode(value) {
	return {
		Value: value,
		Next: null,
		Previous: null,
		LinkedList: null
	}
}