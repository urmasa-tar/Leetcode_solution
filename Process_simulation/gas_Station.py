from typing import List

class Solution:

    def __init__(self):
        pass

    def rec_From_p(self, point: int, curr_gas: int, gas: List[int], cost: List[int]) -> int:
        local_res += cost[point]
        gas_now = curr_gas + gas[point]
        if(point + curr_gas >= len(gas)):
            local_res = 0
        else:
            local_res += cost[point]

        return local_res
    
    def canCompleteCircuit(self, gas: List[int], cost: List[int]) -> int:
        if sum(gas) < sum(cost):
            return -1
                
        curernt_gas = 0
        start = 0
        for i in range(len(gas)):
            curernt_gas += gas[i] - cost[i]
            if curernt_gas < 0:
                curernt_gas = 0
                start = i + 1

        return start