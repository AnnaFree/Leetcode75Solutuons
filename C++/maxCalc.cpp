#include "maxCalc.h"
#include <unordered_map>
#include <iostream>
int maxCalc::maxOperations(std::vector<int>& nums, int k) {
        std::unordered_map<int, int> freq; // Frequency map to store counts of numbers
        int ops = 0;

        for (int num : nums) {
            int complement = k - num;

            // Check for comp calculated earlier that is needed to make pair
            if (freq[complement] > 0) {
                ops++;
                freq[complement]--;
            }
            else {
                freq[num]++;// add the current number to the map
            }
        }

    return ops;
	}


