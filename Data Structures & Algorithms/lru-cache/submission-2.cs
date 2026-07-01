public class Node {
    public Node(int _val = 0, int _key = 0) {
        val = _val;
        key = _key;
    }
    public int val {get; set;}
    public int key {get; set;}
    public Node next {get; set;}
    public Node prev {get; set;}
}

public class LRUCache {
    private int limit {get ; set; }
    private Dictionary<int, Node> cache = new Dictionary<int, Node>();
    private Node head;
    private Node tail;

    private void Remove(Node node) {
        if(node.prev != null) {
            node.prev.next = node.next;
        }
        if(node.next != null) {
            node.next.prev = node.prev;
        }
    }

    private Node Add(int val, int key) {
        Node node = new Node(val, key);
        node.next = head.next;
        node.prev = head;
        if(node.next != null) {
            node.next.prev = node;
        }
        head.next = node;
        return node;
    }

    public LRUCache(int capacity) {
        limit = capacity;
        head = new Node();
        tail = new Node();
        head.next  = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key)) {
            return -1;
        }
        Node node = cache[key];
        Remove(node);
        cache.Remove(key);
        Node newNode = Add(node.val, key);
        cache.Add(key, newNode);
        return node.val;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key)) {
            Node node = cache[key];
            cache.Remove(key);
            Remove(node);
        }
        Node newNode = Add(value, key);
        cache.Add(key, newNode);

        if(cache.Count > limit) {
            Node node = tail.prev;
            Remove(node);
            cache.Remove(node.key);
        }
    }
}
