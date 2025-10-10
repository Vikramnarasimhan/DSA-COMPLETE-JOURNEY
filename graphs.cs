using System;
using System.Collections.Generic;
class Graphs {
    private Dictionary<string , List<string>> adjlist;
    public Graphs() { 

    
        adjlist=new Dictionary<string, List<string>>(); 
    }
    public void addvertex(string vertex) {
        if (!adjlist.ContainsKey(vertex)) {
            adjlist[vertex] = new List<string>();

        }
    }
    public void addedge(string from,string to) {
        addvertex(from); addvertex(to); 
        adjlist[from].Add(to);  
    }
    public void PrintGraph() {
        foreach (var items in adjlist) {
            Console.Write(items.Key+"->");
            Console.WriteLine(string.Join(",",items.Values));
        
        
        
        }
    
    
    
    }




}