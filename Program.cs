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
        int n = Convert.ToInt32(Console.ReadLine());
        UF uf = new UF(n);

        string[] nodes = Console.ReadLine().split();
        while(nodes.Length>0){
            int p = int.Parse(nodes[0]);
            int q = int.Parse(nodes[1]);
            if (!uf.connected(p,q)){
                uf.union(p,q);
                Console.WriteLine("{0} {1}",p,q);
            }
        }
    }
}

class UF { // weighted quick union 
    private int[] id;
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
            //join q to p 
            id[j] = 
        }
    }
    public bool connected(int p,int q){
        return root(p)==root(q);
    }
    private int root(int i){
        if (id[i] == i){ return i;}
        return root(id[i]);
    }
}