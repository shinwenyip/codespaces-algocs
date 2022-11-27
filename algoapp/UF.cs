namespace algoapp;

public class UF { // weighted quick union + path compression(save time looking for root each time)
    public int[] id; //point to parent or root 
    private int[] sz; // count tree size rooted at i 
    public UF(int N){ 
        this.id = new int[N];
        this.sz = new int[N];
        for (int i=0;i <N;i++){ id[i] = i; sz[i]=1;}
    }
    public void union(int p,int q){
        int i = root(p);
        int j = root(q);
        if (i == j) return;
        if (sz[i] < sz[j]){
            //join smaller root to bigger root and update size
            id[i] = j;
            sz[i] += sz[j];
            id[p] = j;
        }else{
            id[j] = i;
            sz[j] += sz[i];
            id[q] = i;
        }

    }
    public bool connected(int p,int q){
        return root(p)==root(q);
    }
    public int root(int i){
        // while(i!=id[i]){
        //     id[i] = id[id[i]];
        //     i = id[i];
        // }
        // return i;
        if (id[i] == i){ return i;}
        int rt = root(id[i]);
        id[i] = rt;
        return rt;
    }
}
// sequence of M Union-Find ops on N objects
// complexity : N + M lg*N
// Percolation :
// N by N grid of sites
// each site open with probability p (blocked w probability 1-p)
// system PERCOLATES iff top and bottom connected by open sites