#include "IncreasingTripletSeq.h"
#include <vector>

bool IncreasingTripletSeq::increasingTriplet(std::vector<int>& nums) {
    bool valid = false;
    for (int i = 1; i < nums.size() - 1; i++) {
        if (nums[i - 1] < nums[i] && nums[i] < nums[i + 1]) {
            valid = true;
        }
    }
    return valid;
}