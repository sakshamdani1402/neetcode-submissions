/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return null;
        Dictionary<Node, Node> map = new();
        Queue<Node> q = new();
        map[node] = new Node(node.val);
        q.Enqueue(node);

        while(q.Count > 0) {
            Node curr = q.Dequeue();
            foreach(Node nei in curr.neighbors) {
                if(!map.ContainsKey(nei)) {
                    map[nei] = new Node(nei.val);
                    q.Enqueue(nei);
                }
                map[curr].neighbors.Add(map[nei]);
            }
        }
        return map[node];
    }
}
