/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head == null) return  null;
        var seen = new Dictionary<Node, Node>();
        Node curr = head;

        while(curr != null) {
            seen[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;

        while(curr != null) {
            if(seen.ContainsKey(curr)) {
                var newNode = seen[curr];
                if(curr.next != null) {
                    newNode.next = seen[curr.next];
                }
                if(curr.random != null) {
                    newNode.random = seen[curr.random];
                }
            }
            curr = curr.next;
        }

        return seen[head];
    }
}
