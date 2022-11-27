namespace algoapp;

public class UFC : UF
{
    private int[] largest;

    public UFC(int N) : base(N){
        largest = new int[N];
        for (int i=0;i<N;i++){largest[i]=i;}
    }
    public int find(int i){
        //return largest element in connected component containing i

    }
}