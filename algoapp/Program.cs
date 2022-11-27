// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

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

            // Console.WriteLine(uf.connected(8,9));
            // Console.WriteLine(uf.connected(7,6));
            // Console.WriteLine(uf.root(7));
            // Console.WriteLine(uf.root(6));

