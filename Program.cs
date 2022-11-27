using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World"); 
        // int n = Convert.ToInt32(Console.ReadLine());
        // UF uf = new UF(n);

        // string[] nodes = Console.ReadLine().split();
        // while(nodes.Length>0){
        //     int p = int.Parse(nodes[0]);
        //     int q = int.Parse(nodes[1]);
        //     if (!uf.connected(p,q)){
        //         uf.union(p,q);
        //         Console.WriteLine("{0} {1}",p,q);
        //     }
        // }

        UF uf = new UF(10);
            uf.union(4,3);
            uf.union(3,8);
            uf.union(6,5);
            uf.union(9,4);
            uf.union(2,1);
            uf.union(5,0);
            uf.union(7,2);
            uf.union(6,1);

            for (int i=0;i <10;i++){Console.Write(uf.id[i]);}

            Console.WriteLine(uf.connected(8,9));
            Console.WriteLine(uf.connected(7,6));
            Console.WriteLine(uf.root(7));
            Console.WriteLine(uf.root(6));
    }
}

class UF { // weighted quick union + path compression(save time looking for root each time)
    private int[] id; //point to parent or root 
    private int[] sz; // count tree size rooted at i 
    public UF(int N){ 
        this.id = new int[N];
        for (int i=0;i <N;i++){ id[i] = i;}
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
    private int root(int i){
        // while(i!=id[i]){
        //     id[i] = id[id[i]];
        //     i = id[i];
        // }
        // return r;
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