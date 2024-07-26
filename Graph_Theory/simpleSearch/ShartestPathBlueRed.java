package Graph_Theory.simpleSearch;

public class ShartestPathBlueRed {
    
    private static final int POSITIVE_INFINITY = Integer.MAX_VALUE;

    public ShartestPathBlueRed(){

    }

    public int[] shortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges) {
        int[] arrOfPath = new int[n];

        return arrOfPath;
    } 

    protected int ShortestPathTo(int[][] setOfColorVert, int begin, int end, int len){
        int anwser = -1;
        int[][] matrixOfPath = new int[len][len];
        boolean[] visited = new boolean[len];
        for(int row = 0; row < len; row++){
            visited[row] = false;
            for(int col = 0; col < len; col++){
                if(col == row){
                    matrixOfPath[row][col] = 0;
                }else{
                    matrixOfPath[row][col] = POSITIVE_INFINITY;
                }
            }
        }

        return anwser;
    }

}
