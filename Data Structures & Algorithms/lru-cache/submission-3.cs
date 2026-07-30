public class Node
{
    public int val {get; set;}
    public int key {get; set; }
    public Node next {get; set;}
    public Node prev {get; set;}

    public Node(int _key  = 0, int _val = 0, Node _next = null, Node _prev = null) {
        val = _val;
        key = _key;
        next = _next;
        prev = _prev;
    }
}

public class LRUCache {
    Dictionary<int, Node> cache;
    int size = 0;
    Node end = null;
    Node head = null;
    public LRUCache(int capacity) {
        cache = new();
        size = capacity;
        end = new Node();
        head = new Node();

        head.next = end;
        end.prev = head;
    }
    
    public int Get(int key) {
        if(!cache.TryGetValue(key, out Node node)) {
            return -1;
        }
        Detach(node);
        Attach(node);
        return node.val;
    }
    
    public void Put(int key, int value) {
        if (cache.TryGetValue(key, out Node existingNode)) {
            // Update value & move to front
            existingNode.val = value;
            Detach(existingNode);
            Attach(existingNode);
            return;
        }

        if(cache.Count >= size) {
            Node lru = end.prev;
            Detach(lru);
            cache.Remove(lru.key);
        }

        Node node = new(key, value);
        cache.Add(key, node);
        Attach(node);
    }

    private void Attach(Node node) {
        node.next = head.next;
        node.prev = head;
        head.next.prev = node;
        head.next = node;
    }

    private void Detach(Node node) {
        node.next.prev = node.prev;
        node.prev.next = node.next;
    }
}
