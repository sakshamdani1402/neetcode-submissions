public class Tweet {
    private int id;
    private int time;
    public Tweet(int id, int timestamp) {
        this.id = id;
        this.time = timestamp;
    }
    public int getId() { return id; }
    public int getTime() {return time; }
}
class Twitter {
    HashMap<Integer, ArrayList<Tweet>> tweets;
    HashMap<Integer, HashSet<Integer>> users;
    int timestamp = 0;

    public Twitter() {
        tweets = new HashMap<Integer, ArrayList<Tweet>>();
        users = new HashMap<Integer, HashSet<Integer>>();
    }
    
    public void postTweet(int userId, int tweetId) {
        tweets.putIfAbsent(userId, new ArrayList<Tweet>());
        tweets.get(userId).add(new Tweet(tweetId, timestamp++));
        // System.out.println(tweets.get(userId));
    }
    
    public List<Integer> getNewsFeed(int userId) {
        List<Integer> following = new ArrayList<Integer>(users.getOrDefault(userId,new HashSet<Integer>()));

        if(following == null) {
            return new ArrayList<Integer>();
        }
        PriorityQueue<Tweet> pq = new PriorityQueue<>((a,b) -> Integer.compare(b.getTime(), a.getTime()));
        var personalTweets = tweets.getOrDefault(userId, new ArrayList<Tweet>());
        pq.addAll(personalTweets);
        for(int user : following) {
            ArrayList<Tweet> t = tweets.get(user);
            if(t == null) {
                continue;
            }
            pq.addAll(t);
        }
        int cnt = 0;
        ArrayList<Integer> result = new ArrayList<>();
        while(cnt != 10 && !pq.isEmpty()) {
           result.add(pq.poll().getId());
           cnt ++;
        }
        return result;
    }
    
    public void follow(int followerId, int followeeId) {
        if(followerId == followeeId) { return ;}
        users.putIfAbsent(followerId, new HashSet<Integer>());
        users.get(followerId).add(followeeId);
    }
    
    public void unfollow(int followerId, int followeeId) {
        if(followerId == followeeId) { return ;}
        HashSet<Integer> f = users.get(followerId);
        if(f == null) {
            return;
        }
        f.remove(followeeId);
    }
}
