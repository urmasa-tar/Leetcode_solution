package Graph_Theory.simpleSearch;

import java.util.List;

public class KeysAndRooms {

    public KeysAndRooms(){}

    public boolean canVisitAllRooms(List<List<Integer>> rooms) {
        boolean result = false;

        /*
        for(int node = 0; node < currentNumber; node++){
            if(cycleFrom(node, rooms, currentNumber)){
                result = true;
                break;
            }
        }
        */ // that was code for all rooms as a option for start
        result = cycleFrom(0, rooms, rooms.size());
        return result;
    }

    //
    private boolean cycleFrom(int startNode, List<List<Integer>> rooms, int numberOfNodes){
        boolean status = false;
        // start from current node
        boolean[] arrOfBool = new boolean[numberOfNodes];
        for(int i = 0; i < numberOfNodes; i++){
            arrOfBool[i] = false;
        }
        boolean[] nodeS = dfsFromNode(rooms, arrOfBool, startNode);
        for(int node = 0; node < nodeS.length; node++){
            if(!nodeS[node])break;
            else{
                if(node == nodeS.length - 1)status = true;
            }
        }
        return status;
    }

    // deep search algorithm
    private boolean[] dfsFromNode(List<List<Integer>> rooms, boolean[] currentStatus, int currentNumber){
        boolean[] res = currentStatus;
        res[currentNumber] = true;
        // List of vertex to another nodes
        List<Integer> arr = rooms.get(currentNumber);
        for (int nodeLink = 0; nodeLink < arr.size(); nodeLink++) {
            if(!res[arr.get(nodeLink)]){
                res = dfsFromNode(rooms, res, arr.get(nodeLink));
            }
        }
        return res;
    }

}
