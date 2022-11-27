namespace algoapp;
public static class Social{
    private int[] ids;
    private int[] sz; // size of each tree
    int biggest;
    public Social(int n){
        this.biggest = 1;
        this.ids = new int[n];
        this.sz = new int[n];
        for (int i=0;i<n;i++){ ids[i]=i; sz[i]=1;}
    }

    public void befriend(int p, int q){ //union
        // join if not connected
        int rp = root(p);
        int rq = root(q);
        if (rp ==rq){return;}
        if (sz[rp] < sz[rq]){
            ids[rp] = rq;
            sz[rq] += sz[rp];
            if(sz[rq]>biggest){biggest = sz[rq];}

        }else{
            ids[rq] = rp;
            sz[rp] += sz[rq];
            if(sz[rp]>biggest){biggest = sz[rp];}
        }
    }
    public bool mutuals(int p, int q){
        return root(p)==root(q);
    }
    private int root(int p){
        while (ids[p]!=p){
            ids[p] = ids[ids[p]];
            p = ids[p];
        }
        return p;
    }
}

//determine the earliest time at which all members are connected
//

int n = 15;
Dictionary<int,(int,int)> logs = new List<int, (int, int)>();
Social net = new Social(n);
int earliest(Dictionary<int,(int,int)> logs){
    foreach (var log in logs){
        var pair = log.Value;
        net.befriend(pair[0],pair[1]);
        if (net.biggest= n){
            return log.Key;
        }
    }
}
