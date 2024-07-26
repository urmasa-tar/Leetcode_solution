
package Graph_Theory.simpleSearch;

import java.util.ArrayList;
import java.util.List;


public class findEventual {
    // There is a directed graph of n nodes with each node labeled from 0 to n - 1
    // Input - > matrix of nodes
    public List<Integer> eventualSafeNodes(int[][] graph) {
        List<Integer> resultNet = new ArrayList<Integer>();
        
        boolean[] statusOfSafety = new boolean[graph.length];
        statusOfSafety = inputInBArr(statusOfSafety);

        for(int node = 0; node < graph.length; node++){
            
        }

        return resultNet;
    }

    private boolean[] inputInBArr(boolean[] arr){
        for (int i = 0; i < arr.length; i++) {
            arr[i] = false;
        }

        return arr;
    }

    protected boolean[] BFS_srart(int[][]graph, boolean[] status, int current){
        boolean[] res = status;
        if(!(graph[current].length == 0)){
            
        }
        // else -> that is terminate node
        return res;
    }
    
}