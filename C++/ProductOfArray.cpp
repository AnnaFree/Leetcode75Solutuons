#include "ProductOfArray.h"
#include <vector>

std::vector<int> productExceptSelf(std::vector<int>& nums) {
    int n = nums.size();
    std::vector<int> answer(n, 1);
    //since i cant have two for loops, i divided the product of answer[i] into multiplying left and right
    int leftProduct = 1;
    int rightProduct = 1;
    for (int i = 0; i < n; i++) {
        // Left product contribution
        answer[i] *= leftProduct;
        leftProduct *= nums[i];

        // Right product contribution
        answer[n - 1 - i] *= rightProduct;
        rightProduct *= nums[n - 1 - i];
    }
    return answer;
}
